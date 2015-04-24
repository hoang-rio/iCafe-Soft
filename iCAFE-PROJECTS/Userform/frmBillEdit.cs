using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Sale;
using iCafeLIB.Controller.Security;

namespace iCafe.Userform
{
    public partial class frmBillEdit : XtraForm
    {
        private readonly DataRow BillRow;
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private string Bill_ID;

        public frmBillEdit(DataRow bRow, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            BillRow = bRow;
            InitializeComponent();
            BinddingData();
            GetBillDetail();
        }

        private void BinddingData()
        {
            try
            {
                Bill_ID = BillRow["Bill_ID"].ToString();
                cbStatus.Text = BillRow["Status"].ToString();
                txtZoneName.Text = BillRow["ZoneName"].ToString();
                txtZoneCost.Text = BillRow["ZoneCost"].ToString();
                txtTable.Text = BillRow["TableName"].ToString();
                txtEvent.Text = BillRow["EventName"].ToString();
                txtCus.Text = BillRow["CusName"].ToString();
                txtValue.Text = BillRow["Value"].ToString();
                spinTotalDiscount.Value = (Decimal) BillRow["TotalDiscount"];
                txtAfterDiscount.Text = BillRow["AfterDiscount"].ToString();
                dateTime.DateTime = (DateTime) BillRow["BTime"];
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void GetBillDetail()
        {
            try
            {
                var sCtrl = new SaleController(mobjConnection, mobjSecurity);
                gridControl1.DataSource = sCtrl.BillDetail_Load(Bill_ID);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}