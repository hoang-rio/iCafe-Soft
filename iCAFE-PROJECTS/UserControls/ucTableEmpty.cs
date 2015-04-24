using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;

namespace iCafe.UserControls
{
    public partial class ucTableEmpty : XtraUserControl
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private DataTable objETable;

        public ucTableEmpty(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (!mobjSecurity._fc_table)
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
            else
            {
                InitializeComponent();
                EmplyTableLoad();
            }
        }

        /// <summary>
        ///     Fill Zone lên gridview
        /// </summary>
        private void EmplyTableLoad()
        {
            try
            {
                var tCtrl = new TableController(mobjConnection, mobjSecurity);
                objETable = tCtrl.GEtTableEmpty();
                gridControl1.DataSource = objETable;
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
    }
}