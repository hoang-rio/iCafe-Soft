using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using iCafe.Userform;
using iCafeLIB.Controller.Customer;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucToolbar_Right : UserControl
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        public string mode = "";

        public ucToolbar_Right(SqlConnection mConnection, SecurityContext mContext)
        {
            m_objConnection = mConnection;
            m_objSecurity = mContext;
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {
            var abc = new frmEmployAdd(m_objConnection, m_objSecurity);
            abc.ShowDialog();
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            var abc = new frmChangePass(m_objConnection, m_objSecurity);
            abc.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var objCustomerController = new CustomerController(m_objConnection, m_objSecurity);
            var objTable = new DataTable();
            objTable = objCustomerController.GetALL();
            var abc = new frmCustomerAdd(objTable, m_objConnection, m_objSecurity);
            abc.ShowDialog();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            var font = new frmFontEdit();
            font.ShowDialog();
            SetFont();
        }

        private void SetFont()
        {
            var f = new Font(ConfigurationSettings.AppSettings.Get("font"),
                int.Parse(ConfigurationSettings.AppSettings.Get("fontsize")), FontStyle.Regular);
            BarAndDockingController.Default.AppearancesRibbon.PageHeader.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.PageCategory.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.PageGroupCaption.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.Item.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.ItemHovered.Font = f;
            BarAndDockingController.Default.AppearancesRibbon.ItemPressed.Font = f;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            var mtAdd = new frmMaterialAdd(m_objConnection, m_objSecurity);
            mtAdd.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var menu = new frmFoodGroupAdd(m_objConnection, m_objSecurity);
            menu.ShowDialog();
        }
    }
}