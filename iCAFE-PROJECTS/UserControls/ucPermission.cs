using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Permisson;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucPermission : XtraUserControl
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private DataTable objTable;

        public ucPermission(SqlConnection objSQLConnect, SecurityContext objSecurity)
        {
            m_objConnection = objSQLConnect;
            m_objSecurity = objSecurity;
            if (m_objSecurity._fc_warehouse)
            {
                InitializeComponent();
                ucBaseController1.btnDong.ItemClick += Close;
                ucBaseController1.btnNapLai.ItemClick += ucPermission_Load;
                ucBaseController1.PressNew += PressAdd;
                ucBaseController1.PressEdit += PressEdit;
                ucBaseController1.PressDelete += Delete_Row;
            }
            else
            {
                XtraMessageBox.Show("Bạn không quyền truy cập mục này");
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PressAdd(object sender, EventArgs e)
        {
            var add = new frmPermissionAdd(m_objConnection, m_objSecurity);
            add.ShowDialog();
        }

        public void PressEdit(object sender, EventArgs args)
        {
            var edit = new frmPermissionAdd(GridPermission.GetDataRow(GridPermission.FocusedRowHandle), m_objConnection,
                m_objSecurity);
            edit.ShowDialog();
        }

        private void LoadData()
        {
            var objPerController = new PermissonController(m_objConnection, m_objSecurity);
            try
            {
                objTable = objPerController.GetAll();
                gridControl1.DataSource = objTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void ucPermission_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Delete_Row(object sender, EventArgs e)
        {
            try
            {
                if (
                    XtraMessageBox.Show("Bạn chắc chắn muốn xóa?", "Hỏi", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    var objPerController = new PermissonController(m_objConnection, m_objSecurity);
                    var PerID = GridPermission.GetFocusedRowCellValue("PerID").ToString();
                    objPerController.Delete(PerID);
                    XtraMessageBox.Show("Xóa thành công");
                    LoadData();
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }
    }
}