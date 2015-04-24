using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;

namespace iCafe.UserControls
{
    public partial class ucTable : XtraUserControl
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private DataTable objTTable;

        public ucTable(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (!mobjSecurity._fc_table)
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                Dispose();
            }
            else
            {
                InitializeComponent();
                TableLoad();
                ucBaseController1.PressNew += Add_Click;
                ucBaseController1.PressEdit += Edit_Click;
                ucBaseController1.PressDelete += Delete_Click;
                ucBaseController1.PressClose += ucBaseController1_PressClose;
                ucBaseController1.PressRefresh += ucBaseController1_PressRefresh;
            }
        }

        private void ucBaseController1_PressClose(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ucBaseController1_PressRefresh(object sender, EventArgs e)
        {
            TableLoad();
        }

        /// <summary>
        ///     Load Table lên grid
        /// </summary>
        private void TableLoad()
        {
            try
            {
                var tCtrl = new TableController(mobjConnection, mobjSecurity);
                objTTable = tCtrl.GetAll();
                gridControl1.DataSource = objTTable;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Thêm bàn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var tAdd = new frmTableAdd(mobjConnection, mobjSecurity);
                tAdd.ShowDialog();
                TableLoad();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var tAdd = new frmTableAdd(gridView1.GetFocusedDataRow(), mobjConnection, mobjSecurity);
                tAdd.ShowDialog();
                TableLoad();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var tController = new TableController(mobjConnection, mobjSecurity);
                tController.Delete(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TableID").ToString());
                gridView1.DeleteSelectedRows();
                XtraMessageBox.Show("Xóa thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}