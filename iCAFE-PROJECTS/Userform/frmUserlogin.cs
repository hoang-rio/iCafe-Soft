using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.Commons;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Users;

namespace iCafe.Userform
{
    public partial class frmUserlogin : XtraForm
    {
        private readonly SecurityContext m_objSecurity;
        private SqlConnection m_objConnection;

        public frmUserlogin(SqlConnection objConnection, SecurityContext objSecurity)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurity;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND: //preventing the form from being moved by the mouse.
                    var command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)
                //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }

        private void bbtnlogin_Click(object sender, EventArgs e)
        {
            if (m_objConnection.State == ConnectionState.Closed || m_objConnection.State == ConnectionState.Broken)
            {
                m_objConnection = (new Services().getConnection());
            }
            LoginExcute();
        }

        private void LoginExcute()
        {
            errorProviderMsg.Clear();

            if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                errorProviderMsg.SetError(txtusername, "Bạn cần nhập tài khoản đăng nhập");
                return;
            }
            if (string.IsNullOrEmpty(txtpw.Text.Trim()))
            {
                errorProviderMsg.SetError(txtpw, "Bạn cần nhập mật khẩu đăng nhập");
                return;
            }
            try
            {
                var strUserName = txtusername.Text.Trim();
                var strPassword = txtpw.Text;

                var objUser = new UserController(m_objConnection, m_objSecurity);
                objUser.Checklogin(strUserName, strPassword);
                if (m_objSecurity._LoginSuccess)
                {
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("Thông tin tài khoản không đúng. Vui lòng nhập lại", "Thông báo");
                    errorProviderMsg.SetError(txtusername, "Thông tin tài khoản không đúng. Vui lòng nhập lại");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmUserlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!m_objSecurity._LoginSuccess)
            {
                Application.Exit();
            }
        }
    }
}