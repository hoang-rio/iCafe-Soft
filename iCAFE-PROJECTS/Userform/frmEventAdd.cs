using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Event;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmEventAdd : XtraForm
    {
        private readonly ErrorProvider error = new ErrorProvider();
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly iCafeDataEn.iCafe_EventDataTable objEvtTable = new iCafeDataEn.iCafe_EventDataTable();
        private readonly DataRow objRow;

        public frmEventAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        public frmEventAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            objRow = row;
            DataBindding();
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        private void this_Close(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var cctr = new EventController(m_objConnection, m_objSecurity);
                var row = (iCafeDataEn.iCafe_EventRow) objEvtTable.NewRow();
                row.EventID = Guid.NewGuid();
                row.EventName = txtEventName.Text;
                row.Status = (byte) cbStatus.SelectedIndex;
                row.Discount = spinDiscount.Value;
                row.StartDate = dateStartDate.DateTime;
                row.EndDate = dateEndDate.DateTime;
                row.CreateDate = DateTime.Now;
                row.Descript = txtDescript.Text;
                objEvtTable.Rows.Add(row);
                cctr.Add_new(objEvtTable);
                XtraMessageBox.Show("Thêm sự kiện mới thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var cctr = new EventController(m_objConnection, m_objSecurity);
                var row = (iCafeDataEn.iCafe_EventRow) objEvtTable.NewRow();
                row.EventID = (Guid) objRow["EventID"];
                row.EventName = txtEventName.Text;
                row.Status = (byte) cbStatus.SelectedIndex;
                row.Discount = spinDiscount.Value;
                row.StartDate = dateStartDate.DateTime;
                row.EndDate = dateEndDate.DateTime;
                row.CreateDate = (DateTime) objRow["CreateDate"];
                row.Descript = txtDescript.Text;
                objEvtTable.Rows.Add(row);
                cctr.Update(objEvtTable);
                SetValue();
                XtraMessageBox.Show("Sửa thông tin sự kiện thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void SetValue()
        {
            objRow["EventName"] = txtEventName.Text;
            objRow["Status"] = cbStatus.Text;
            objRow["Discount"] = spinDiscount.Value;
            objRow["StartDate"] = dateStartDate.DateTime;
            objRow["EndDate"] = dateEndDate.DateTime;
            objRow["Descript"] = txtDescript.Text;
            objRow["CreateDate"] = objRow["CreateDate"];
        }

        private void DataBindding()
        {
            var cctr = new EventController(m_objConnection, m_objSecurity);
            txtEventName.Text = objRow["EventName"].ToString();
            cbStatus.Text = objRow["Status"].ToString();
            spinDiscount.Value = Decimal.Parse(objRow["Discount"].ToString());
            dateStartDate.DateTime = (DateTime) objRow["StartDate"];
            dateEndDate.DateTime = (DateTime) objRow["EndDate"];
            txtDescript.Text = objRow["Descript"].ToString();
        }

        private void CheckNull()
        {
            if (cbStatus.SelectedIndex == -1)
            {
                error.SetError(cbStatus, "Vui lòng thiết lập trạng thái");
            }
        }
    }
}