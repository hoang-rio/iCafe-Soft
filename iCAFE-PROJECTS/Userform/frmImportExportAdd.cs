using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Material;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmImportExportAdd : XtraForm
    {
        private readonly Guid IEID;
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly DataRow objRow;
        private readonly byte type;
        //DataTable objBTdtTable = new DataTable();
        private DataTable DetailTable = new DataTable();

        public frmImportExportAdd(byte add, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            type = add;
            cbType.SelectedIndex = type;
            Add_Column();
            gridControl1.DataSource = DetailTable;
            IEID = Guid.NewGuid();
            txtCost.Properties.ReadOnly = true;
            ucSimpleControl1.btnThemmoi.ItemClick += Add_Material;
            ucSimpleControl1.btnFXoa.ItemClick += Delete_Material;
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        public frmImportExportAdd(byte add, DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            objRow = row;
            type = add;
            cbType.SelectedIndex = type;
            ucSimpleControl1.btnThemmoi.ItemClick += Add_Material;
            ucSimpleControl1.btnFXoa.ItemClick += Delete_Material;
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        private void this_Close(object sender, EventArgs e)
        {
            Dispose();
        }

        public void getValue(decimal Total)
        {
            txtCost.Text = Total.ToString();
        }

        private void Add_Column()
        {
            DetailTable.Columns.Add("IEID", Type.GetType("System.Guid"));
            DetailTable.Columns.Add("RMID", Type.GetType("System.Guid"));
            DetailTable.Columns.Add("ImportDate", Type.GetType("System.DateTime"));
            DetailTable.Columns.Add("ExpireDate", Type.GetType("System.DateTime"));
            DetailTable.Columns.Add("RMName", Type.GetType("System.String"));
            DetailTable.Columns.Add("Unit", Type.GetType("System.String"));
            DetailTable.Columns.Add("RMPrice", Type.GetType("System.Decimal"));
            DetailTable.Columns.Add("Quantity", Type.GetType("System.Decimal"));
            DetailTable.Columns.Add("TotalPrice", Type.GetType("System.Decimal"));
            DetailTable.Columns.Add("DetailNote", Type.GetType("System.String"));
        }

        private void Load_IEDetail()
        {
            try
            {
                var detailController = new IEDetailController(m_objConnection, m_objSecurity);
                DetailTable = detailController.GetByIEID(objRow["IEID"].ToString());
                DetailTable.Columns.Add("TotalPrice", typeof (String));
                foreach (DataRow dr in DetailTable.Rows)
                {
                    dr["TotalPrice"] = ((Decimal) dr["RMPrice"]*(Decimal) dr["Quantity"]).ToString();
                }
                gridControl1.DataSource = DetailTable;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Add_Material(object sender, EventArgs e)
        {
            var materialAdd = new frmIEDetail_MaterialAdd(DetailTable, IEID, m_objConnection, m_objSecurity);
            materialAdd.getTotalValue = getValue;
            materialAdd.ShowDialog();
        }

        private void Delete_Material(object sender, EventArgs e)
        {
            DetailTable.Rows.RemoveAt(gridIEDetail.GetFocusedDataSourceRowIndex());
            Decimal valuenow = 0;
            if (gridIEDetail.RowCount != 0)
            {
                foreach (DataRow valuerow in DetailTable.Rows)
                {
                    valuenow += Decimal.Parse(valuerow["TotalPrice"].ToString());
                }
            }

            else valuenow = 0;
            txtCost.Text = valuenow.ToString();
        }

        private void SetValue()
        {
            objRow["Status"] = (byte) cbStatus.SelectedIndex;
            objRow["Type"] = type;
            objRow["Time"] = dateTime.DateTime;
            objRow["Cost"] = Decimal.Parse(txtCost.Text);
            objRow["IEnote"] = txtIENote.Text;
        }

        private void DataBindding()
        {
            cbStatus.Text = objRow["Status"].ToString();
            dateTime.DateTime = (DateTime) objRow["Time"];
            cbType.SelectedIndex = type;
            txtCost.Text = objRow["Cost"].ToString();
            cbType.Properties.ReadOnly = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var cctr = new ImportExportController(m_objConnection, m_objSecurity);
                var objIETable = new iCafeDataEn.iCafe_ImportExportDataTable();
                var row = (iCafeDataEn.iCafe_ImportExportRow) objIETable.NewRow();
                var detail = new IEDetailController(m_objConnection, m_objSecurity);
                iCafeDataEn.iCafe_IEDetailDataTable objDtTable;
                var dtRow = new iCafeDataEn.iCafe_IEDetailRow[DetailTable.Rows.Count];
                row.IEID = IEID;
                row.Time = dateTime.DateTime;
                row.Cost = Decimal.Parse(txtCost.Text);
                row.Type = (type == 1) ? true : false;
                row.IENote = txtIENote.Text;
                row.Status = (byte) cbStatus.SelectedIndex;
                objIETable.Rows.Add(row);
                cctr.AddNew(objIETable);
                for (var i = 0; i < DetailTable.Rows.Count; i++)
                {
                    objDtTable = new iCafeDataEn.iCafe_IEDetailDataTable();
                    dtRow[i] = objDtTable.NewiCafe_IEDetailRow();
                    dtRow[i].IEID = IEID;
                    dtRow[i].ImportDate = (DateTime) DetailTable.Rows[i]["ImportDate"];
                    dtRow[i].ExpireDate = (DateTime) DetailTable.Rows[i]["ExpireDate"];
                    dtRow[i].RMID = (Guid) DetailTable.Rows[i]["RMID"];
                    dtRow[i].Quantity = (Decimal) DetailTable.Rows[i]["Quantity"];
                    dtRow[i].DetailNote = DetailTable.Rows[i]["DetailNote"].ToString();
                    objDtTable.Rows.Add(dtRow[i]);
                    detail.AddNew(objDtTable);
                }
                XtraMessageBox.Show("Thêm phiếu nguyên liệu mới thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var cctr = new ImportExportController(m_objConnection, m_objSecurity);
                var objIETable = new iCafeDataEn.iCafe_ImportExportDataTable();
                var row = (iCafeDataEn.iCafe_ImportExportRow) objIETable.NewRow();
                var detail = new IEDetailController(m_objConnection, m_objSecurity);
                iCafeDataEn.iCafe_IEDetailDataTable objDtTable;
                var dtRow = new iCafeDataEn.iCafe_IEDetailRow[DetailTable.Rows.Count];
                row.IEID = (Guid) objRow["IEID"];
                row.Time = dateTime.DateTime;
                row.Cost = Decimal.Parse(txtCost.Text);
                row.Type = (type == 0) ? true : false;
                row.IENote = txtIENote.Text;
                row.Status = (byte) cbStatus.SelectedIndex;
                objIETable.Rows.Add(row);
                detail.Delete(objRow["IEID"].ToString());
                cctr.Update(objIETable);
                SetValue();
                for (var i = 0; i < DetailTable.Rows.Count; i++)
                {
                    objDtTable = new iCafeDataEn.iCafe_IEDetailDataTable();
                    dtRow[i] = objDtTable.NewiCafe_IEDetailRow();
                    dtRow[i].IEID = (Guid) objRow["IEID"];
                    dtRow[i].ImportDate = (DateTime) DetailTable.Rows[i]["ImportDate"];
                    dtRow[i].ExpireDate = (DateTime) DetailTable.Rows[i]["ExpireDate"];
                    dtRow[i].RMID = (Guid) DetailTable.Rows[i]["RMID"];
                    dtRow[i].Quantity = (Decimal) DetailTable.Rows[i]["Quantity"];
                    dtRow[i].DetailNote = DetailTable.Rows[i]["DetailNote"].ToString();
                    objDtTable.Rows.Add(dtRow[i]);
                    detail.AddNew(objDtTable);
                }
                XtraMessageBox.Show("Sửa thông tin phiếu nguyên liệu thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void frmImportExportAdd_Load(object sender, EventArgs e)
        {
            if (objRow != null)
            {
                Load_IEDetail();
                DataBindding();
            }
        }
    }
}