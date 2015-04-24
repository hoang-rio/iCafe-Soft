using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Customer;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;
using iCafeLIB.Controller.Zone;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmBookTableAdd : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly DataRow objRow;
        private readonly string ZoneName = "";
        private Guid BTableID;
        private DataTable objBTdtTable = new DataTable();

        /// <summary>
        ///     Hàm tạo thêm mới
        /// </summary>
        /// <param name="ZoneName">Tên khu vực</param>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public frmBookTableAdd(string zName, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            BTableID = Guid.NewGuid();
            CusLoad();
            ZoneLoad();
            Add_Column();
            ZoneName = zName;
            gridControl1.DataSource = objBTdtTable;
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucSimpleControl1.btnThemmoi.ItemClick += AddFood;
            ucSimpleControl1.btnFXoa.ItemClick += Delete_Food;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            ucSimpleControl1.btnEdit.ItemClick += Edit_Food_Click;
        }

        /// <summary>
        ///     Hàm tạo sửa
        /// </summary>
        /// <param name="row"></param>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public frmBookTableAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            objRow = row;
            CusLoad();
            ZoneLoad();
            TableByZone();
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            ucSimpleControl1.btnFXoa.ItemClick += BookTableDetailDelete_Click;
            ucSimpleControl1.btnThemmoi.ItemClick += BookTableDetailAdd_Click;
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucSimpleControl1.btnEdit.ItemClick += Edit_Food_Click;
            gridView1.ValidateRow += Quantity_Validate;
        }

        private void Add_Column()
        {
            objBTdtTable.Columns.Add("BTableID", Type.GetType("System.Guid"));
            objBTdtTable.Columns.Add("FoodName", Type.GetType("System.String"));
            objBTdtTable.Columns.Add("FoodID", Type.GetType("System.Guid"));
            objBTdtTable.Columns.Add("Quantity", Type.GetType("System.Decimal"));
            objBTdtTable.Columns.Add("FUnit", Type.GetType("System.String"));
            objBTdtTable.Columns.Add("FPrice", Type.GetType("System.Decimal"));
            objBTdtTable.Columns.Add("TotalPrice", Type.GetType("System.Decimal"));
        }

        private void BinddingData()
        {
            try
            {
                BTableID = (Guid) objRow["BTableID"];
                cbStatus.SelectedIndex = (byte) objRow["Status"];
                dateBookTime.DateTime = (DateTime) objRow["BookTime"];
                dateEndTime.DateTime = (DateTime) objRow["EndTime"];
                lookZone.Text = objRow["ZoneName"].ToString();
                lookCus.EditValue = objRow["CusName"].ToString();
                lookTable.Text = objRow["TableName"].ToString();
                txtDeposit.Text = objRow["Deposit"].ToString();
                spinNumPeople.Value = (Decimal) objRow["Numpeople"];
                txtDescript.Text = objRow["Descript"].ToString();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void GetBookTableDetail()
        {
            try
            {
                var btController = new BookTableController(mobjConnection, mobjSecurity);
                objBTdtTable = btController.GetDetail(BTableID.ToString());
                gridControl1.DataSource = objBTdtTable;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void SetValue()
        {
            try
            {
                objRow["BTableID"] = BTableID;
                objRow["Status"] = cbStatus.SelectedIndex;
                objRow["BookTime"] = dateBookTime.DateTime;
                objRow["EndTime"] = dateEndTime.DateTime;
                objRow["ZoneName"] = lookZone.Text;
                objRow["CusName"] = lookCus.Text;
                objRow["Numpeople"] = spinNumPeople.Value;
                objRow["TableName"] = lookTable.Text;
                objRow["Deposit"] = txtDeposit.Text;
                objRow["Descript"] = txtDescript.Text;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void CusLoad()
        {
            try
            {
                var cusCtrl = new CustomerController(mobjConnection, mobjSecurity);
                lookCus.Properties.DataSource = cusCtrl.GetALL();
                lookCus.Properties.DisplayMember = "CusName";
                lookCus.Properties.ValueMember = "CusName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void ZoneLoad()
        {
            try
            {
                var zCtrl = new ZoneController(mobjConnection, mobjSecurity);
                lookZone.Properties.DataSource = zCtrl.GetAll();
                lookZone.Properties.DisplayMember = "ZoneName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void TableByZone()
        {
            try
            {
                var tCtrl = new TableController(mobjConnection, mobjSecurity);
                lookTable.Properties.DataSource = tCtrl.GetByZoneName(lookZone.Text);
                lookTable.Properties.DisplayMember = "TableName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void AddFood(object sender, EventArgs e)
        {
            var foodAdd = new frmBookTable_FoodAdd(objBTdtTable, BTableID, mobjConnection, mobjSecurity);
            foodAdd.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        ///     Xóa món đặt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Food(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void lookZone_EditValueChanged(object sender, EventArgs e)
        {
            TableByZone();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var objBtTable = new iCafeDataEn.iCafe_BookTableDataTable();
                var row = objBtTable.NewiCafe_BookTableRow();
                row.BTableID = BTableID;
                row.BookTime = dateBookTime.DateTime;
                row.EndTime = dateEndTime.DateTime;
                row.CusID =
                    (Guid)
                        lookCus.Properties.View.GetRowCellValue(lookCus.Properties.View.FocusedRowHandle, "CusID");
                row.Descript = txtDescript.Text;
                row.Deposit = int.Parse(txtDeposit.Text);
                row.NumPeople = spinNumPeople.Value;
                row.ZoneID =
                    (Guid) ((DataRowView) lookZone.Properties.GetDataSourceRowByKeyValue(lookZone.EditValue))["ZoneID"];
                row.TableID =
                    (Guid)
                        ((DataRowView) lookTable.Properties.GetDataSourceRowByKeyValue(lookTable.EditValue))["TableID"];
                row.Status = (byte) cbStatus.SelectedIndex;
                objBtTable.Rows.Add(row);
                //-------------------------------------------------------//
                var objDtTable = new iCafeDataEn.iCafe_BookTableDetailDataTable();
                var dtRow = new iCafeDataEn.iCafe_BookTableDetailRow[objBTdtTable.Rows.Count];
                for (var i = 0; i < objBTdtTable.Rows.Count; i++)
                {
                    dtRow[i] = objDtTable.NewiCafe_BookTableDetailRow();
                    dtRow[i].BTableID = (Guid) objBTdtTable.Rows[i]["BTableID"];
                    dtRow[i].FoodID = (Guid) objBTdtTable.Rows[i]["FoodID"];
                    dtRow[i].Quantity = (Decimal) objBTdtTable.Rows[i]["Quantity"];
                    dtRow[i].TotalPrice = (Decimal) objBTdtTable.Rows[i]["TotalPrice"];

                    objDtTable.Rows.Add(dtRow[i]);
                }

                var btController = new BookTableController(mobjConnection, mobjSecurity);
                btController.AddNew(objBtTable, objDtTable);
                XtraMessageBox.Show("Thêm thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void frmBookTableAdd_Load(object sender, EventArgs e)
        {
            if (ZoneName != "")
            {
                lookZone.Text = ZoneName;
            }
            if (objRow != null)
            {
                BinddingData();
                GetBookTableDetail();
            }
        }

        private void BookTableDetailDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var btController = new BookTableController(mobjConnection, mobjSecurity);
                var objTable = new iCafeDataEn.iCafe_BookTableDetailDataTable();
                var row = objTable.NewiCafe_BookTableDetailRow();
                row.BTableID = (Guid) gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BTableID");
                row.FoodID = (Guid) gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FoodID");
                objTable.Rows.Add(row);
                btController.Delete_Detail(objTable);
                gridView1.DeleteSelectedRows();
                XtraMessageBox.Show("Xóa thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void BookTableDetailAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmBookTable_FoodAdd(true, objBTdtTable, BTableID, mobjConnection, mobjSecurity);
                frm.ShowDialog();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var objBtTable = new iCafeDataEn.iCafe_BookTableDataTable();
                var row = objBtTable.NewiCafe_BookTableRow();
                row.BTableID = BTableID;
                row.BookTime = dateBookTime.DateTime;
                row.EndTime = dateEndTime.DateTime;
                row.CusID =
                    (Guid)
                        lookCus.Properties.View.GetRowCellValue(lookCus.Properties.View.FocusedRowHandle, "CusID");
                row.Descript = txtDescript.Text;
                row.Deposit = int.Parse(txtDeposit.Text);
                row.NumPeople = spinNumPeople.Value;
                row.ZoneID =
                    (Guid)
                        ((DataRowView) lookZone.Properties.GetDataSourceRowByKeyValue(lookZone.EditValue))["ZoneID"];
                row.TableID =
                    (Guid)
                        ((DataRowView) lookTable.Properties.GetDataSourceRowByKeyValue(lookTable.EditValue))[
                            "TableID"];
                row.Status = (byte) cbStatus.SelectedIndex;
                objBtTable.Rows.Add(row);
                //-------------------------------------------------------//                

                var btController = new BookTableController(mobjConnection, mobjSecurity);
                btController.Update(objBtTable);
                SetValue();
                XtraMessageBox.Show("Cập nhật thành công");
            }
            catch (NullReferenceException)
            {
                XtraMessageBox.Show("Đã có lỗi. Hãy thử chọn lại khách hàng");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Edit_Food_Click(object sender, EventArgs e)
        {
            try
            {
                gridView1.Columns["Quantity"].OptionsColumn.AllowEdit = true;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Quantity_Validate(object sender, EventArgs e)
        {
            try
            {
                var row = gridView1.GetFocusedDataRow();
                row["TotalPrice"] = (Decimal) row["Quantity"]*(Decimal) row["FPrice"];
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}