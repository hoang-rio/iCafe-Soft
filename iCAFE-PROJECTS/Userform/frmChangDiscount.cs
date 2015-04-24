using System;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Customer;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmChangDiscount : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;

        public frmChangDiscount(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            CusLoad();
            ucUpdate1.btnFCapNhat.ItemClick += SetDiscount_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            ucUpdate1.btnFNapLai.ItemClick += PressRefress_Click;
        }

        private void SetDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                var objCusTable = new iCafeDataEn.iCafe_CustomerDataTable();
                var row = objCusTable.NewiCafe_CustomerRow();
                var fcRow = lookCus.Properties.View.GetFocusedDataRow();
                row.Discount = spinDiscount.Value;
                //-------------------------------------------------///
                row.Company = fcRow["Company"].ToString();
                row.CusAddress = fcRow["CusAddress"].ToString();
                row.CusID = (Guid) fcRow["CusID"];
                row.CusName = fcRow["CusName"].ToString();
                row.CusPhone = fcRow["CusPhone"].ToString();
                row.CusSex = fcRow["CusSex"].ToString() == "Nam" ? true : false;
                row.Birthday = (DateTime) fcRow["Birthday"];
                objCusTable.Rows.Add(row);
                var cusController = new CustomerController(mobjConnection, mobjSecurity);
                cusController.Update(objCusTable);
                XtraMessageBox.Show("Cập nhật thành công");
                Dispose();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void CusLoad()
        {
            try
            {
                var cusCtrl = new CustomerController(mobjConnection, mobjSecurity);
                lookCus.Properties.DataSource = cusCtrl.GetALL();
                lookCus.Properties.DisplayMember = "CusName";
                lookCus.Properties.ValueMember = "CusName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void lookCus_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                spinDiscount.Value =
                    (Decimal) lookCus.Properties.View.GetRowCellValue(lookCus.Properties.View.FocusedRowHandle,
                        "Discount");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PressRefress_Click(object sender, EventArgs e)
        {
            CusLoad();
        }
    }
}