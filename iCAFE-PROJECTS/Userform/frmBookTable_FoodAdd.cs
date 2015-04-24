using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Food;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Material;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmBookTable_FoodAdd : XtraForm
    {
        public delegate void getToTal(decimal Total);

        private readonly Guid BTableID;
        private readonly DataColumnCollection columns;
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly DataTable objBTdtTable = new DataTable();
        public getToTal getTotalValue;
        private DataRow objBTdtRow;
        private DataTable objFoodTable;
        //Hàm tạo thêm mới

        public frmBookTable_FoodAdd(DataTable objTable, Guid objBTableID, SqlConnection objConnection,
            SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            objBTdtTable = objTable;
            BTableID = objBTableID;
            FoodGroup_Load();
            columns = GetColumns(objTable);
            if (columns.Contains("BGID"))
            {
                ucUpdate1.btnFCapNhat.ItemClick += Add_Ballot_Click;
            }
            else
            {
                ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            }
            ucUpdate1.btnFDong.ItemClick += Close_Click;
        }

        private static DataColumnCollection GetColumns(DataTable objTable)
        {
            var columns = objTable.Columns;
            return columns;
        }

        private void Add_Ballot_Click(object sender, EventArgs e)
        {
            try
            {
                var view = lookFood.Properties.View;
                var food = view.GetRowCellValue(view.FocusedRowHandle, "FoodName").ToString();
                if (objBTdtTable.Rows.Count > 0)
                {
                    foreach (DataRow erow in objBTdtTable.Rows)
                    {
                        if (string.Compare(erow["FoodName"].ToString(), food) == 0)
                        {
                            erow["Quantity"] = (Decimal) erow["Quantity"] + spinQuantity.Value;
                            erow["TotalPrice"] = (Decimal) erow["Quantity"]*(Decimal) erow["FPrice"];
                            food = "";
                        }
                    }
                }
                if (food != "")
                {
                    objBTdtRow = objBTdtTable.NewRow();
                    objBTdtRow["BGID"] = BTableID;
                    objBTdtRow["FoodID"] = (Guid) view.GetRowCellValue(view.FocusedRowHandle, "FoodID");
                    objBTdtRow["Quantity"] = spinQuantity.Value;
                    objBTdtRow["FoodName"] = view.GetRowCellValue(view.FocusedRowHandle, "FoodName");
                    objBTdtRow["FUnit"] = view.GetRowCellValue(view.FocusedRowHandle, "FUnit");
                    objBTdtRow["FPrice"] = view.GetRowCellValue(view.FocusedRowHandle, "FPrice");
                    objBTdtRow["TotalPrice"] = (spinQuantity.Value*
                                                (Decimal) view.GetRowCellValue(view.FocusedRowHandle, "FPrice"));
                    objBTdtTable.Rows.Add(objBTdtRow);
                }
                if (getTotalValue != null)
                {
                    decimal value = 0;
                    foreach (DataRow row in objBTdtTable.Rows)
                    {
                        value += Decimal.Parse(row["TotalPrice"].ToString());
                    }
                    getTotalValue(value);
                }
                Text = "Thêm thành công";
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
                objBTdtRow = objBTdtTable.NewRow();
                var view = lookFood.Properties.View;
                var food = view.GetRowCellValue(view.FocusedRowHandle, "FoodName").ToString();
                if (objBTdtTable.Rows.Count > 0)
                {
                    foreach (DataRow erow in objBTdtTable.Rows)
                    {
                        if (string.Compare(erow["FoodName"].ToString(), food) == 0)
                        {
                            erow["Quantity"] = (Decimal) erow["Quantity"] + spinQuantity.Value;
                            erow["TotalPrice"] = (Decimal) erow["Quantity"]*(Decimal) erow["FPrice"];
                            food = "";
                        }
                    }
                }
                if (food != "")
                {
                    objBTdtRow["BTableID"] = BTableID;
                    objBTdtRow["FoodID"] = (Guid) view.GetRowCellValue(view.FocusedRowHandle, "FoodID");
                    objBTdtRow["Quantity"] = spinQuantity.Value;
                    objBTdtRow["FoodName"] = view.GetRowCellValue(view.FocusedRowHandle, "FoodName");
                    objBTdtRow["FUnit"] = view.GetRowCellValue(view.FocusedRowHandle, "FUnit");
                    objBTdtRow["FPrice"] = view.GetRowCellValue(view.FocusedRowHandle, "FPrice");
                    objBTdtRow["TotalPrice"] = (spinQuantity.Value*
                                                (Decimal) view.GetRowCellValue(view.FocusedRowHandle, "FPrice"));
                    objBTdtTable.Rows.Add(objBTdtRow);
                }
                Text = "Thêm thành công";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Food_Load(object sender, EventArgs e)
        {
            objFoodTable = (new FoodController(mobjConnection, mobjSecurity).GetFoodByFGrName(lookFGroup.Text));
            lookFood.Properties.DataSource = objFoodTable;
            lookFood.Properties.DisplayMember = "FoodName";
        }

        private void FoodGroup_Load()
        {
            try
            {
                lookFGroup.Properties.DataSource = (new FoodGroupController(mobjConnection, mobjSecurity)).GetAll();
                lookFGroup.Properties.DisplayMember = "FGrName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void lookFood_EditValueChanged(object sender, EventArgs e)
        {
            Text = "iCafe - Project";
        }

        private void lookFood_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                picFood.Image =
                    ImageController.ConvertByteToImage(
                        (byte[])
                            lookFood.Properties.View.GetRowCellValue(lookFood.Properties.View.FocusedRowHandle, "FImage"));
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}