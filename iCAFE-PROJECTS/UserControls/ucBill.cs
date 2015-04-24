using System;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Sale;
using iCafeLIB.Controller.Search;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucBill : XtraUserControl
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;

        /// <summary>
        ///     Khởi tạo bill
        /// </summary>
        /// <param name="cbbIndex">
        ///     Kiểu tìm kiếm 0: Tìm theo tên khách hàng. 1: Tìm theo tên bàn. 2: Tìm theo tên nhân viên. 3: Tìm
        ///     theo thời gian
        /// </param>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public ucBill(int cbbIndex, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (!mobjSecurity._fc_revenue)
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                Dispose();
            }
            else
            {
                InitializeComponent();
                BillLoad();
                cbbType.SelectedIndex = cbbIndex;
                btnDetail.Click += btnDetail_Click;
            }
        }

        private void BillLoad()
        {
            try
            {
                var sCtrl = new SaleController(mobjConnection, mobjSecurity);
                gridControl1.DataSource = sCtrl.GetAll();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                var billEdit = new frmBillEdit(gridView1.GetFocusedDataRow(), mobjConnection, mobjSecurity);
                billEdit.ShowDialog();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception);
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == 3)
            {
                labeldate.Visible = true;
                dateBill.Visible = true;
            }
            else
            {
                labeldate.Visible = false;
                dateBill.Visible = false;
            }
        }

        private void txtKeyWord_EditValueChanged(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == 0)
            {
                SearchByCusName();
            }
            if (cbbType.SelectedIndex == 1)
            {
                SearchByTableName();
            }
            if (cbbType.SelectedIndex == 2)
            {
                SearchByEmployName();
            }
            if (cbbType.SelectedIndex == 3)
            {
            }
        }

        private void SearchByCusName()
        {
            try
            {
                var bSearchController = new BillSearchController(mobjConnection, mobjSecurity);
                gridControl1.DataSource = bSearchController.SearchByCusName(txtKeyWord.Text);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void SearchByEmployName()
        {
            try
            {
                var bSearchController = new BillSearchController(mobjConnection, mobjSecurity);
                gridControl1.DataSource = bSearchController.SearchByEmployName(txtKeyWord.Text);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void SearchByTableName()
        {
            try
            {
                var bSearchController = new BillSearchController(mobjConnection, mobjSecurity);
                gridControl1.DataSource = bSearchController.SearchByTableName(txtKeyWord.Text);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void SearchByDate()
        {
            try
            {
                var bSearchController = new BillSearchController(mobjConnection, mobjSecurity);
                gridControl1.DataSource = bSearchController.SearchByDate(dateBill.DateTime);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void dateBill_EditValueChanged(object sender, EventArgs e)
        {
            SearchByDate();
        }
    }
}