using System;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.Security;

namespace iCafe.Userform
{
    public partial class frmSearchBox : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly int Stype;

        public frmSearchBox(int Type, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (!mobjSecurity._fc_system)
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                Dispose();
            }
            else
            {
                InitializeComponent();
                ucUpdate1.btnFCapNhat.ItemClick += Close_Click;
                ucUpdate1.btnFDong.ItemClick += Exit_Click;
                Stype = Type;
                if (Stype == 0)
                {
                    lblkeyword.Visible = true;
                    txtkeyWord.Visible = true;
                }
                else
                {
                    lblCa.Visible = true;
                    lookWS.Visible = true;
                    LoadWS();
                }
            }
        }

        private void LoadWS()
        {
            try
            {
                var WSCtrl = new WorkShiftController(mobjConnection, mobjSecurity);
                lookWS.Properties.DataSource = WSCtrl.GetAll();
                lookWS.Properties.DisplayMember = "WSName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}