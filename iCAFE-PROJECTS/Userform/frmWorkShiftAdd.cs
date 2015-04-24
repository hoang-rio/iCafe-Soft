using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmWorkShiftAdd : XtraForm
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly DataRow objRow;

        public frmWorkShiftAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            spinStartTime.Text = "";
            spinStartTime.Text = "";
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        public frmWorkShiftAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
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
                var cctr = new WorkShiftController(m_objConnection, m_objSecurity);
                var objWorkTable = new iCafeDataEn.iCafe_WorkShiftDataTable();
                var row = (iCafeDataEn.iCafe_WorkShiftRow) objWorkTable.NewRow();
                row.WSID = Guid.NewGuid();
                row.WSName = txtWSName.Text;
                row.StartTime = TimeSpan.ParseExact(spinStartTime.Text, "g", CultureInfo.CurrentCulture);
                row.EndTime = TimeSpan.ParseExact(spinEndTime.EditValue.ToString(), "g", CultureInfo.CurrentCulture);
                row.Expense = Decimal.Parse(txtExpense.Text);
                row.WSNote = txtWSNote.Text;
                objWorkTable.Rows.Add(row);
                cctr.AddNew(objWorkTable);
                XtraMessageBox.Show("Thêm ca trực mới thành công");
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
                var cctr = new WorkShiftController(m_objConnection, m_objSecurity);
                var objWorkTable = new iCafeDataEn.iCafe_WorkShiftDataTable();
                var row = (iCafeDataEn.iCafe_WorkShiftRow) objWorkTable.NewRow();
                row.WSID = (Guid) objRow["WSID"];
                row.WSName = txtWSName.Text;
                row.StartTime = TimeSpan.ParseExact(spinStartTime.Text, "g", CultureInfo.CurrentCulture);
                row.EndTime = TimeSpan.ParseExact(spinEndTime.Text, "g", CultureInfo.CurrentCulture);
                row.Expense = Decimal.Parse(txtExpense.Text);
                row.WSNote = txtWSNote.Text;
                objWorkTable.Rows.Add(row);
                cctr.Update(objWorkTable);
                SetValue();
                XtraMessageBox.Show("Sửa thông tin ca trực thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void SetValue()
        {
            objRow["WSName"] = txtWSName.Text;
            objRow["StartTime"] = TimeSpan.ParseExact(spinStartTime.Text, "g", CultureInfo.CurrentCulture);
            objRow["EndTime"] = TimeSpan.ParseExact(spinEndTime.Text, "g", CultureInfo.CurrentCulture);
            objRow["Expense"] = Decimal.Parse(txtExpense.Text);
            objRow["WSNote"] = txtWSNote.Text;
        }

        private void DataBindding()
        {
            var cctr = new WorkShiftController(m_objConnection, m_objSecurity);
            txtWSName.Text = objRow["WSName"].ToString();
            spinStartTime.EditValue = objRow["StartTime"].ToString().Substring(0, 5);
            spinEndTime.EditValue = objRow["EndTime"].ToString().Substring(0, 5);
            txtExpense.Text = objRow["Expense"].ToString();
            txtWSNote.Text = objRow["WSNote"].ToString();
        }
    }
}