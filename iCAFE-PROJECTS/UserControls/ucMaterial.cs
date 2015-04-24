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
    public partial class ucMaterial : XtraUserControl
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private DataTable objTable;

        public ucMaterial(SqlConnection objSQLConnect, SecurityContext objSecurity)
        {
            m_objConnection = objSQLConnect;
            m_objSecurity = objSecurity;
            if (m_objSecurity._fc_warehouse)
            {
                InitializeComponent();
                ucBaseController1.btnDong.ItemClick += Close;
                ucBaseController1.btnNapLai.ItemClick += ucMaterial_Load;
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
            var add = new frmMaterialAdd(m_objConnection, m_objSecurity);
            add.ShowDialog();
        }

        public void PressEdit(object sender, EventArgs args)
        {
            var edit = new frmMaterialAdd(gridRawMaterial.GetDataRow(gridRawMaterial.FocusedRowHandle), m_objConnection,
                m_objSecurity);
            edit.ShowDialog();
        }

        private void ucMaterial_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var objMaterialController = new RawMaterialController(m_objConnection, m_objSecurity);
            try
            {
                objTable = objMaterialController.GetALL();
                gridMaterial.DataSource = objTable;
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
                    var objMaterialController = new RawMaterialController(m_objConnection, m_objSecurity);
                    var RMID = gridRawMaterial.GetFocusedRowCellValue("RMID").ToString();
                    objMaterialController.Delete(RMID);
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