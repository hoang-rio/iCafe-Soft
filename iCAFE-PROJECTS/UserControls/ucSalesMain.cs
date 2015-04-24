using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using iCafe.Userform;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucSalesMain : UserControl
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly PanelControl PanelMain;

        public ucSalesMain(PanelControl panel, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            PanelMain = panel;
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var ucBT = new ucBookTable(mobjConnection, mobjSecurity);
                ucBT.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(ucBT);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var ucMn = new ucMenu(mobjConnection, mobjSecurity);
                ucMn.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(ucMn);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var ucS = new ucSales(mobjConnection, mobjSecurity);
                ucS.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(ucS);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnZoneTable_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var ucMn = new ucBookTable(mobjConnection, mobjSecurity);
                ucMn.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(ucMn);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnMaterialFood_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof (frmwait));
            PanelMain.Controls.Clear();
            var ucMn = new ucFood(mobjConnection, mobjSecurity);
            ucMn.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(ucMn);
            SplashScreenManager.CloseForm();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                PanelMain.Controls.Clear();
                var ucMn = new ucCustomer(mobjConnection, mobjSecurity);
                ucMn.Dock = DockStyle.Fill;
                PanelMain.Controls.Add(ucMn);
                SplashScreenManager.CloseForm();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}