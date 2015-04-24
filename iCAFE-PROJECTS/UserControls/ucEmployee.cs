using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucEmployee : XtraUserControl
    {
        private readonly string keyword;
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly int sType = -1;
        //userController m_objUserControllers;
        private DataTable objTable;

        public ucEmployee(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            if (m_objSecurity._fc_system)
            {
                InitializeComponent();
                ucBaseController1.PressClose += ucBaseController1_PressClose;
                ucBaseController1.btnNapLai.ItemClick += ucEmployee_Load;
                ucBaseController1.PressNew += PressAdd;
                ucBaseController1.PressEdit += PressEdit;
                ucBaseController1.PressDelete += Delete_Row;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        /// <summary>
        ///     Hàm tạo tìm kiếm
        /// </summary>
        /// <param name="Type">Kiểu 0: Theo tên. 1: Theo ca. 2: Đang làm việc</param>
        /// <param name="kw">Từ khóa tìm kiếm</param>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public ucEmployee(int Type, string kw, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            if (m_objSecurity._fc_system)
            {
                InitializeComponent();
                keyword = kw;
                sType = Type;
                ucBaseController1.PressClose += ucBaseController1_PressClose;
                ucBaseController1.btnNapLai.ItemClick += ucEmployee_Load;
                ucBaseController1.PressNew += PressAdd;
                ucBaseController1.PressEdit += PressEdit;
                ucBaseController1.PressDelete += Delete_Row;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            if (sType == -1)
            {
                LoadData();
            }

            if (sType == 0)
            {
                var emController = new EmployeeController(m_objConnection, m_objSecurity);
                gridControl1.DataSource = emController.GetByFullName(keyword);
            }
            if (sType == 1)
            {
                var emController = new EmployeeController(m_objConnection, m_objSecurity);
                gridControl1.DataSource = emController.GetByWorkShift(keyword);
            }
            if (sType == 2)
            {
                var emController = new EmployeeController(m_objConnection, m_objSecurity);
                gridControl1.DataSource = emController.GetWorking();
            }
        }

        private void PressAdd(object sender, EventArgs args)
        {
            var add = new frmEmployAdd(m_objConnection, m_objSecurity);
            add.ShowDialog();
        }

        public void ucBaseController1_PressClose(object sender, EventArgs e)
        {
            Dispose();
        }

        public void PressEdit(object sender, EventArgs args)
        {
            var edit = new frmEmployAdd(gridEmploy.GetDataRow(gridEmploy.FocusedRowHandle), m_objConnection,
                m_objSecurity);
            edit.ShowDialog();
        }

        private void LoadData()
        {
            var objEmTable = new EmployeeController(m_objConnection, m_objSecurity);
            try
            {
                objTable = objEmTable.GetAll();
                gridControl1.DataSource = objTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra. Chi tiết: " + ex.Message);
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
                    var objEmployeeController = new EmployeeController(m_objConnection, m_objSecurity);
                    var EmployID = gridEmploy.GetFocusedRowCellValue("EmployID").ToString();
                    objEmployeeController.Delete(EmployID);
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