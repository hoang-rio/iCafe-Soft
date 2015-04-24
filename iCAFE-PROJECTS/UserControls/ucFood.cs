using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Food;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucFood : XtraUserControl
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private DataTable objFTable;

        public ucFood(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (mobjSecurity._fc_warehouse)
            {
                InitializeComponent();
                FillFood((new object()), null);
                ucBaseController1.PressNew += Add_Food_Click;
                ucBaseController1.PressDelete += Delete_Food_Click;
                ucBaseController1.PressClose += Close_Click;
                ucBaseController1.PressEdit += Edit_Food_Click;
                ucBaseController1.PressRefresh += FillFood;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Delete_Food_Click(object sender, EventArgs e)
        {
            try
            {
                var fController = new FoodController(mobjConnection, mobjSecurity);
                var fcRow = gridFood.GetFocusedDataRow();
                fController.Delete(fcRow["FoodID"].ToString());
                XtraMessageBox.Show("Đã xóa");
                FillFood(sender, e);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Add_Food_Click(object sender, EventArgs e)
        {
            var foodAdd = new frmFoodAdd(objFTable, "", mobjConnection, mobjSecurity);
            foodAdd.ShowDialog();
        }

        private void Edit_Food_Click(object sender, EventArgs e)
        {
            var foodEdit = new frmFoodAdd(gridFood.GetFocusedDataRow(), mobjConnection, mobjSecurity);
            foodEdit.ShowDialog();
        }

        private void FillFood(object sender, EventArgs e)
        {
            try
            {
                var fController = new FoodController(mobjConnection, mobjSecurity);
                objFTable = fController.GetAll();
                gridControl2.DataSource = objFTable;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}