using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Zone;

namespace iCafe.UserControls
{
    public partial class ucZone : XtraUserControl
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private DataTable objZTable;

        public ucZone(SqlConnection objConnection, SecurityContext objSecurityContext)
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
                ZoneLoad();
                ucBaseController1.PressNew += Add_Click;
                ucBaseController1.PressEdit += Edit_Click;
                ucBaseController1.PressClose += Close_Click;
                ucBaseController1.PressDelete += Delete_Click;
                ucBaseController1.PressRefresh += ucBaseController1_PressRefresh;
            }
        }

        private void ucBaseController1_PressRefresh(object sender, EventArgs e)
        {
            ZoneLoad();
        }

        /// <summary>
        ///     Fill Zone lên gridview
        /// </summary>
        private void ZoneLoad()
        {
            try
            {
                var zCtrl = new ZoneController(mobjConnection, mobjSecurity);
                objZTable = zCtrl.GetAll();
                gridControl1.DataSource = objZTable;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Thêm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var zAdd = new frmZoneAdd(objZTable, mobjConnection, mobjSecurity);
                zAdd.ShowDialog();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Sửa Zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var zAdd = new frmZoneAdd(gridView1.GetFocusedDataRow(), mobjConnection, mobjSecurity);
                zAdd.ShowDialog();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Close UserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var zController = new ZoneController(mobjConnection, mobjSecurity);
                zController.Delete(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ZoneID").ToString());
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