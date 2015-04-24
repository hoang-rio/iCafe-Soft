using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Customer;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmCustomerAdd : XtraForm
    {
        private readonly ErrorProvider error = new ErrorProvider();
        private readonly SqlConnection mobjConnection;
        private readonly DataTable mobjCusTable = new DataTable();
        private readonly SecurityContext mobjSecurity;
        private readonly DataRow objRow;

        public frmCustomerAdd(DataTable objTable, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            mobjCusTable = objTable;
            groupKH.Text = "Thêm khách hàng mới";
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        public frmCustomerAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            groupKH.Text = "Sửa thông tin khách hàng";
            objRow = row;
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
            DataBindding();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND: //preventing the form from being moved by the mouse.
                    var command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)
                //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }

        private void this_Close(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNull())
                {
                    var Cctr = new CustomerController(mobjConnection, mobjSecurity);
                    var objCusTable = new iCafeDataEn.iCafe_CustomerDataTable();
                    var objCusRow = (iCafeDataEn.iCafe_CustomerRow) objCusTable.NewRow();
                    objCusRow.CusID = Guid.NewGuid();
                    objCusRow.CusName = txtCusName.Text;
                    objCusRow.CusSex = cbSex.SelectedIndex == 0 ? true : false;
                    objCusRow.CusPhone = txtCusPhone.Text;
                    objCusRow.CusAddress = txtCusAddress.Text;
                    objCusRow.Company = txtCompany.Text;
                    objCusRow.Birthday = dateCusNS.DateTime;
                    objCusRow.Discount = spinCK.Value;
                    objCusTable.Rows.Add(objCusRow);
                    Cctr.AddNew(objCusTable);
                    mobjCusTable.ImportRow(objCusRow);
                    XtraMessageBox.Show("Thêm khách hàng mới thành công");
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void DataBindding()
        {
            try
            {
                txtCusName.Text = objRow["CusName"].ToString();
                txtCusPhone.Text = objRow["CusPhone"].ToString();
                txtCusAddress.Text = objRow["CusAddress"].ToString();
                cbSex.Text = objRow["CusSex"].ToString();
                spinCK.Value = Decimal.Parse(objRow["Discount"].ToString());
                dateCusNS.DateTime = (DateTime) objRow["Birthday"];
                txtCompany.Text = objRow["Company"].ToString();
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
                var objCusTable = new iCafeDataEn.iCafe_CustomerDataTable();
                var row = (iCafeDataEn.iCafe_CustomerRow) objCusTable.NewRow();
                var cusCtrl = new CustomerController(mobjConnection, mobjSecurity);
                row.CusName = txtCusName.Text;
                row.CusID = (Guid) objRow["CusID"];
                row.CusSex = cbSex.SelectedIndex == 0 ? true : false;
                row.CusAddress = txtCusAddress.Text;
                row.CusPhone = txtCusPhone.Text;
                row.Company = txtCompany.Text;
                row.Discount = spinCK.Value;
                row.Birthday = dateCusNS.DateTime;
                objCusTable.Rows.Add(row);
                cusCtrl.Update(objCusTable);
                SetValue();
                XtraMessageBox.Show("Sửa thông tin thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void SetValue()
        {
            objRow["CusName"] = txtCusName.Text;
            objRow["CusPhone"] = txtCusPhone.Text;
            objRow["CusAddress"] = txtCusAddress.Text;
            objRow["CusSex"] = cbSex.SelectedItem.ToString();
            objRow["Discount"] = spinCK.Value;
            objRow["Birthday"] = dateCusNS.DateTime;
            objRow["Company"] = txtCompany.Text;
        }

        private bool CheckNull()
        {
            error.Clear();
            try
            {
                if (txtCusName.Text == "")
                {
                    error.SetError(txtCusName, "Tên khách hàng không được để trống");
                    return false;
                }
                if (txtCusPhone.Text == "")
                {
                    error.SetError(txtCusPhone, "Số điện thoại không được để trống");
                    return false;
                }
                if (txtCusAddress.Text == "")
                {
                    error.SetError(txtCusAddress, "Vui lòng nhập địa chỉ");
                    return false;
                }
                if (cbSex.SelectedIndex == -1)
                {
                    error.SetError(cbSex, "Hãy chọn giới tính");
                    return false;
                }
                if (txtCompany.Text == "")
                {
                    error.SetError(txtCompany, "Hãy nhập tên công ty");
                    return false;
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
            return true;
        }
    }
}