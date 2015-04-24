using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Customer;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucCustomer : XtraUserControl
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private string Name;
        private DataTable objTable;

        public ucCustomer(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            if (m_objSecurity._fc_Customer)
            {
                InitializeComponent();
                ucBaseController1.btnDong.ItemClick += Close;
                ucBaseController1.PressNew += PressAdd;
                ucBaseController1.PressRefresh += PressRefresh;
                ucBaseController1.PressDelete += Delete_Row;
                ucBaseController1.PressEdit += PressEdit;
                LoadData();
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        public ucCustomer(string name, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            if (m_objSecurity._fc_Customer)
            {
                InitializeComponent();
                Name = name;
                ucBaseController1.btnDong.ItemClick += Close;
                ucBaseController1.PressNew += PressAdd;
                ucBaseController1.PressDelete += Delete_Row;
                ucBaseController1.PressEdit += PressEdit;
                SearchByName();
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        private void PressRefresh(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchByName()
        {
            try
            {
                var cCtrl = new CustomerController(m_objConnection, m_objSecurity);
                gridControl1.DataSource = cCtrl.ByName(Name);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Close(object sender, EventArgs args)
        {
            Dispose();
        }

        private void PressAdd(object sender, EventArgs e)
        {
            var add = new frmCustomerAdd(objTable, m_objConnection, m_objSecurity);
            add.ShowDialog();
        }

        private void PressEdit(object sender, EventArgs e)
        {
            var Edit = new frmCustomerAdd(gridView1.GetFocusedDataRow(), m_objConnection, m_objSecurity);
            Edit.ShowDialog();
        }

        private void LoadData()
        {
            var objCustomerController = new CustomerController(m_objConnection, m_objSecurity);
            try
            {
                objTable = objCustomerController.GetALL();
                gridControl1.DataSource = objTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
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
                    var objCustomerController = new CustomerController(m_objConnection, m_objSecurity);
                    var CusID = gridView1.GetFocusedRowCellValue("CusID").ToString();
                    objCustomerController.Delete(CusID);
                    XtraMessageBox.Show("Xóa thành công");
                    gridView1.DeleteSelectedRows();
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }
    }
}