using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Permisson;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmSalary : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;

        public frmSalary(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (mobjSecurity._fc_system)
            {
                InitializeComponent();
                PerLoad();
                ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
                ucUpdate1.btnFDong.ItemClick += Close_Click;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                Dispose();
            }
        }

        public void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PerLoad()
        {
            try
            {
                var perCtrl = new PermissonController(mobjConnection, mobjSecurity);
                lookPer.Properties.DataSource = perCtrl.GetAll();
                lookPer.Properties.DisplayMember = "PerName";
                lookPer.Properties.ValueMember = "PerName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception);
            }
        }

        public void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var objTable = new iCafeDataEn.iCafe_PermissionDataTable();
                var row = objTable.NewiCafe_PermissionRow();
                row.PerID =
                    (Guid) ((DataRowView) lookPer.Properties.GetDataSourceRowByKeyValue(lookPer.EditValue))["PerID"];
                row.SalaryValue = Decimal.Parse(txtSalaryValue.Text);
                row.SalaryOverTime = Decimal.Parse(txtSalaryOverTime.Text);
                objTable.Rows.Add(row);
                var sCtrl = new SalaryController(mobjConnection, mobjSecurity);
                sCtrl.Update(objTable);
                XtraMessageBox.Show("Cập nhật thành công");
                PerLoad();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void lookPer_EditValueChanged(object sender, EventArgs e)
        {
            if (((DataRowView) lookPer.Properties.GetDataSourceRowByKeyValue(lookPer.EditValue))["SalaryValue"] != null)
            {
                txtSalaryValue.Text =
                    ((DataRowView) lookPer.Properties.GetDataSourceRowByKeyValue(lookPer.EditValue))["SalaryValue"]
                        .ToString();
            }
            if (((DataRowView) lookPer.Properties.GetDataSourceRowByKeyValue(lookPer.EditValue))["SalaryOverTime"] !=
                null)
            {
                txtSalaryOverTime.Text =
                    ((DataRowView) lookPer.Properties.GetDataSourceRowByKeyValue(lookPer.EditValue))["SalaryOverTime"]
                        .ToString();
            }
        }
    }
}