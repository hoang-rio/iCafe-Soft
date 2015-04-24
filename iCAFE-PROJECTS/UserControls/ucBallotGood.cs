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
    public partial class ucBallotGood : XtraUserControl
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private DataTable objTable;

        public ucBallotGood(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            if (m_objSecurity._fc_warehouse)
            {
                InitializeComponent();
                ucBaseController1.PressClose += Close;
                ucBaseController1.btnNapLai.ItemClick += ucBallotGood_Load;
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
            var add = new frmBallotGoodAdd(m_objConnection, m_objSecurity);
            add.ShowDialog();
        }

        public void PressEdit(object sender, EventArgs args)
        {
            var edit = new frmBallotGoodAdd(gridBallotGood.GetDataRow(gridBallotGood.FocusedRowHandle), m_objConnection,
                m_objSecurity);
            edit.ShowDialog();
        }

        private void LoadData()
        {
            var objMaterialController = new BallotGoodsController(m_objConnection, m_objSecurity);
            try
            {
                objTable = objMaterialController.GetALL();
                gridControl1.DataSource = objTable;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void ucBallotGood_Load(object sender, EventArgs e)
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
                    var objBallotController = new BallotGoodsController(m_objConnection, m_objSecurity);
                    var BGID = gridBallotGood.GetFocusedRowCellValue("BGID").ToString();
                    var objDetailController = new BallotDetailController(m_objConnection, m_objSecurity);
                    objDetailController.Delete(BGID);
                    objBallotController.Delete(BGID);
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