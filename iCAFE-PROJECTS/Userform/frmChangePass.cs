using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmChangePass : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;

        public frmChangePass(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (mobjSecurity._LoginSuccess)
            {
                InitializeComponent();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa đăng nhập");
                Dispose();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangepw_Click(object sender, EventArgs e)
        {
            var errorProvider = new ErrorProvider();
            if (txtoldpw.Text == "")
            {
                errorProvider.SetError(txtoldpw, "Bạn cần nhập mật khẩu cũ");
            }
            else
            {
                if (txtnewpw.Text == "")
                {
                    errorProvider.SetError(txtnewpw, "Bạn cần nhập mật khẩu mới");
                }

                else
                {
                    if (txtnewpw.Text != txtretypepw.Text)
                    {
                        errorProvider.SetError(txtretypepw, "Mật khẩu mới không khớp");
                    }
                    else
                    {
                        var emCtrl = new EmployeeController(mobjConnection, mobjSecurity);
                        var objEmTable = new iCafeDataEn.iCafe_EmployeeDataTable();
                        var row = (iCafeDataEn.iCafe_EmployeeRow) objEmTable.NewRow();
                        row.UserName = mobjSecurity._UserName;
                        row.PassW = txtoldpw.Text;
                        row.EmployID = Guid.NewGuid();
                        objEmTable.Rows.Add(row);
                        if (emCtrl.Checkpw(objEmTable))
                        {
                            row.PassW = txtnewpw.Text;
                            emCtrl.Changepw(objEmTable);
                            XtraMessageBox.Show("Đổi mật khẩu thành công");
                            Close();
                        }
                        else
                        {
                            errorProvider.SetError(txtoldpw, "Mật khẩu không đúng vui lòng thử lại");
                        }
                    }
                }
            }
        }
    }
}