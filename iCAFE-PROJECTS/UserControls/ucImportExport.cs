using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Material;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucImportExport : XtraUserControl
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly byte type;
        private DataTable objTable;

        public ucImportExport(int newtype, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            type = (byte) newtype;
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            if (m_objSecurity._fc_warehouse)
            {
                InitializeComponent();
                ucBaseController1.PressClose += Close;
                ucBaseController1.btnNapLai.ItemClick += ucImportExport_Load;
                ucBaseController1.PressNew += PressAdd;
                ucBaseController1.PressEdit += PressEdit;
                ucBaseController1.PressDelete += Delete_Row;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PressAdd(object sender, EventArgs e)
        {
            var add = new frmImportExportAdd(type, m_objConnection, m_objSecurity);
            add.ShowDialog();
        }

        public void PressEdit(object sender, EventArgs args)
        {
            var edit = new frmImportExportAdd(type, gridImportExport.GetDataRow(gridImportExport.FocusedRowHandle),
                m_objConnection,
                m_objSecurity);
            edit.ShowDialog();
        }

        private void LoadData()
        {
            var objIEController = new ImportExportController(m_objConnection, m_objSecurity);
            try
            {
                objTable = objIEController.LoadALL(type.ToString());
                gridControl1.DataSource = objTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void ucImportExport_Load(object sender, EventArgs e)
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
                    var objIEController = new ImportExportController(m_objConnection, m_objSecurity);
                    var IEID = gridImportExport.GetFocusedRowCellValue("IEID").ToString();
                    var objDetailController = new IEDetailController(m_objConnection, m_objSecurity);
                    objDetailController.Delete(IEID);
                    objIEController.Delete(IEID);
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