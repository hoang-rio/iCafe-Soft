using System;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmBonusPunishAdd : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly bool mode = true; //true là thưởng false là phạt

        public frmBonusPunishAdd(SqlConnection objConnection, SecurityContext objSecurityContext, bool m)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mode = m;
            if (mode)
            {
                cbType.SelectedIndex = 0;
            }
            else
            {
                cbType.SelectedIndex = 1;
            }
            EmployLoad();
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void EmployLoad()
        {
            try
            {
                var eCtrl = new EmployeeController(mobjConnection, mobjSecurity);
                lookEmploy.Properties.DataSource = eCtrl.GetAll();
                lookEmploy.Properties.DisplayMember = "FullName";
                lookEmploy.Properties.ValueMember = "EmployID";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var objTable = new iCafeDataEn.iCafe_Bonus_PunishDataTable();
                var row = objTable.NewiCafe_Bonus_PunishRow();
                row.EmployID = (Guid) lookEmploy.EditValue;

                row.Content = txtContent.Text;
                row.Time = DateTime.Now;
                if (cbType.SelectedIndex == 0)
                {
                    row.Value = int.Parse(txtValue.Text);
                }
                else
                {
                    row.Value = -int.Parse(txtValue.Text);
                }
                objTable.Rows.Add(row);
                var bnController = new BonusPunishController(mobjConnection, mobjSecurity);
                bnController.AddNew(objTable);
                XtraMessageBox.Show("Thêm thành công");
                Dispose();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }}
}