using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Event;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucEvent : XtraUserControl
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly bool RunningEvt;

        public ucEvent(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            if (m_objSecurity._fc_event)
            {
                InitializeComponent();
                ucBaseController1.PressClose += PressClose;
                ucBaseController1.PressNew += PressAdd;
                ucBaseController1.PressEdit += PressEdit;
                ucBaseController1.PressRefresh += ucBaseController1_Load;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        public ucEvent(bool REvt, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            RunningEvt = REvt;
            if (m_objSecurity._fc_event)
            {
                InitializeComponent();
                ucBaseController1.PressClose += PressClose;
                ucBaseController1.PressNew += PressAdd;
                ucBaseController1.PressEdit += PressEdit;
                ucBaseController1.PressRefresh += ucBaseController1_Load;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        private void PressClose(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ucBaseController1_Load(object sender, EventArgs e)
        {
            ucBaseController1.Delete_Remove();
            LoadData();
        }

        private void LoadData()
        {
            DataTable objTable;
            var evtController = new EventController(m_objConnection, m_objSecurity);
            try
            {
                if (RunningEvt)
                {
                    objTable = evtController.GetEventNow();
                    gridControl1.DataSource = objTable;
                }
                else
                {
                    objTable = evtController.GetAll();
                    gridControl1.DataSource = objTable;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void PressAdd(object sender, EventArgs e)
        {
            var add = new frmEventAdd(m_objConnection, m_objSecurity);
            add.ShowDialog();
        }

        private void PressEdit(object sender, EventArgs e)
        {
            var edit = new frmEventAdd(gridEvent.GetDataRow(gridEvent.FocusedRowHandle), m_objConnection, m_objSecurity);
            edit.ShowDialog();
        }
    }
}