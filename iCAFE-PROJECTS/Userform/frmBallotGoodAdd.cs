using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Material;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmBallotGoodAdd : XtraForm
    {
        private readonly Guid BGID;
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly DataRow objRow;
        //DataTable objBTdtTable = new DataTable();
        private DataTable DetailTable = new DataTable();
        private string SupName = "";
        private DataTable SupTable;

        public frmBallotGoodAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            Add_Column();
            Load_Supplier();
            gridControl1.DataSource = DetailTable;
            BGID = Guid.NewGuid();
            txtValue.Properties.ReadOnly = true;
            ucSimpleControl1.btnThemmoi.ItemClick += AddFood;
            ucSimpleControl1.btnFXoa.ItemClick += Delete_Food;
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        public frmBallotGoodAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            objRow = row;
            Load_Supplier();
            ucSimpleControl1.btnThemmoi.ItemClick += AddFood;
            ucSimpleControl1.btnFXoa.ItemClick += Delete_Food;
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        private void this_Close(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Load_Supplier()
        {
            try
            {
                var supController = new SupplierController(m_objConnection, m_objSecurity);
                SupTable = supController.GetALL();
                lookUpSupID.Properties.DataSource = SupTable;
                lookUpSupID.Properties.DisplayMember = "SupName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Add_Column()
        {
            DetailTable.Columns.Add("BGID", Type.GetType("System.Guid"));
            DetailTable.Columns.Add("FoodID", Type.GetType("System.Guid"));
            DetailTable.Columns.Add("FoodName", Type.GetType("System.String"));
            DetailTable.Columns.Add("FUnit", Type.GetType("System.String"));
            DetailTable.Columns.Add("FPrice", Type.GetType("System.Decimal"));
            DetailTable.Columns.Add("Quantity", Type.GetType("System.Decimal"));
            DetailTable.Columns.Add("TotalPrice", Type.GetType("System.Decimal"));
        }

        public void getValue(decimal Total)
        {
            txtValue.Text = Total.ToString();
        }

        private void Load_BallotDetail()
        {
            try
            {
                var detailController = new BallotDetailController(m_objConnection, m_objSecurity);
                DetailTable = detailController.GetByBGID(objRow["BGID"].ToString());
                DetailTable.Columns.Add("TotalPrice", typeof (String));
                foreach (DataRow dr in DetailTable.Rows)
                {
                    dr["TotalPrice"] = ((Decimal) dr["FPrice"]*(Decimal) dr["Quantity"]).ToString();
                }
                gridControl1.DataSource = DetailTable;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var cctr = new BallotGoodsController(m_objConnection, m_objSecurity);
                var objBallotTable = new iCafeDataEn.iCafe_BallotGoodsDataTable();
                var row = (iCafeDataEn.iCafe_BallotGoodsRow) objBallotTable.NewRow();
                var detail = new BallotDetailController(m_objConnection, m_objSecurity);
                iCafeDataEn.iCafe_BallotDetailDataTable objDtTable;
                var dtRow = new iCafeDataEn.iCafe_BallotDetailRow[DetailTable.Rows.Count];
                row.BGID = BGID;
                row.CreatTime = dateCreateDate.DateTime;
                row.Value = Decimal.Parse(txtValue.Text);
                row.SupID = (Guid) SupTable.Rows[lookUpSupID.ItemIndex]["SupID"];
                row.Status = (byte) cbStatus.SelectedIndex;
                objBallotTable.Rows.Add(row);
                cctr.AddNew(objBallotTable);
                //SetValue();
                for (var i = 0; i < DetailTable.Rows.Count; i++)
                {
                    objDtTable = new iCafeDataEn.iCafe_BallotDetailDataTable();
                    dtRow[i] = objDtTable.NewiCafe_BallotDetailRow();
                    dtRow[i].BGID = BGID;
                    dtRow[i].FoodID = (Guid) DetailTable.Rows[i]["FoodID"];
                    dtRow[i].Quantity = (Decimal) DetailTable.Rows[i]["Quantity"];
                    objDtTable.Rows.Add(dtRow[i]);
                    detail.AddNew(objDtTable);
                }
                XtraMessageBox.Show("Thêm phiếu hàng mới thành công");
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
                var cctr = new BallotGoodsController(m_objConnection, m_objSecurity);
                var objBallotTable = new iCafeDataEn.iCafe_BallotGoodsDataTable();
                var row = (iCafeDataEn.iCafe_BallotGoodsRow) objBallotTable.NewRow();
                var detail = new BallotDetailController(m_objConnection, m_objSecurity);
                iCafeDataEn.iCafe_BallotDetailDataTable objDtTable;
                var dtRow = new iCafeDataEn.iCafe_BallotDetailRow[DetailTable.Rows.Count];
                row.BGID = (Guid) objRow["BGID"];
                row.CreatTime = dateCreateDate.DateTime;
                row.Value = Decimal.Parse(txtValue.Text);
                row.SupID = (Guid) SupTable.Rows[lookUpSupID.ItemIndex]["SupID"];
                row.Status = (byte) cbStatus.SelectedIndex;
                objBallotTable.Rows.Add(row);
                detail.Delete(objRow["BGID"].ToString());
                cctr.Update(objBallotTable);
                SetValue();
                for (var i = 0; i < DetailTable.Rows.Count; i++)
                {
                    objDtTable = new iCafeDataEn.iCafe_BallotDetailDataTable();
                    dtRow[i] = objDtTable.NewiCafe_BallotDetailRow();
                    dtRow[i].BGID = (Guid) objRow["BGID"];
                    dtRow[i].FoodID = (Guid) DetailTable.Rows[i]["FoodID"];
                    dtRow[i].Quantity = (Decimal) DetailTable.Rows[i]["Quantity"];
                    objDtTable.Rows.Add(dtRow[i]);
                    detail.AddNew(objDtTable);
                }
                XtraMessageBox.Show("Sửa thông tin phiếu hàng thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void AddFood(object sender, EventArgs e)
        {
            var foodAdd = new frmBookTable_FoodAdd(DetailTable, BGID, m_objConnection, m_objSecurity);
            foodAdd.getTotalValue = getValue;
            foodAdd.ShowDialog();
        }

        /// <summary>
        ///     Xóa món đặt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Food(object sender, EventArgs e)
        {
            //gridView1.DeleteSelectedRows();
            DetailTable.Rows.RemoveAt(gridView1.GetFocusedDataSourceRowIndex());
            Decimal valuenow = 0;
            if (gridView1.RowCount != 0)
            {
                foreach (DataRow valuerow in DetailTable.Rows)
                {
                    valuenow += Decimal.Parse(valuerow["TotalPrice"].ToString());
                }
            }

            else valuenow = 0;
            txtValue.Text = valuenow.ToString();
        }

        private void SetValue()
        {
            objRow["SupName"] = lookUpSupID.Text;
            objRow["CreatTime"] = dateCreateDate.DateTime;
            objRow["Value"] = Decimal.Parse(txtValue.Text);
            objRow["Status"] = cbStatus.Text;
        }

        private void DataBindding()
        {
            dateCreateDate.DateTime = (DateTime) objRow["CreatTime"];
            SupName = objRow["SupName"].ToString();
            txtValue.Text = objRow["Value"].ToString();
            txtValue.Properties.ReadOnly = true;
            cbStatus.Text = objRow["Status"].ToString();
        }

        private void frmBallotGoodAdd_Load(object sender, EventArgs e)
        {
            if (objRow != null)
            {
                Load_BallotDetail();
                DataBindding();
            }
            if (SupName != "")
            {
                lookUpSupID.Text = SupName;
            }
        }
    }
}