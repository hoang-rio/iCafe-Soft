using System;
using System.Data.SqlClient;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucBonusPunish : XtraUserControl
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;

        public ucBonusPunish(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (mobjSecurity._fc_system)
            {
                InitializeComponent();
                LoadBonusPunish();
                ucBaseController1.PressClose += Close_Click;
                ucBaseController1.PressRefresh += ucBaseController1_PressRefresh;
                ucBaseController1.PressNew += Add_Click;
                ucBaseController1.bBITimKiem.Visibility = BarItemVisibility.Never;
                ucBaseController1.btnEdit.Visibility = BarItemVisibility.Never;
                ucBaseController1.btnXoa.Visibility = BarItemVisibility.Never;
                ucBaseController1.btnTroGiup.Visibility = BarItemVisibility.Never;
                ucBaseController1.btnBaoCao.Visibility = BarItemVisibility.Never;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                Dispose();
            }
        }

        private void ucBaseController1_PressRefresh(object sender, EventArgs e)
        {
            LoadBonusPunish();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var bp = new frmBonusPunishAdd(mobjConnection, mobjSecurity, true);
                bp.ShowDialog();
                LoadBonusPunish();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void LoadBonusPunish()
        {
            try
            {
                var bpController = new BonusPunishController(mobjConnection, mobjSecurity);
                gridControl1.DataSource = bpController.GetAll();
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
    }
}