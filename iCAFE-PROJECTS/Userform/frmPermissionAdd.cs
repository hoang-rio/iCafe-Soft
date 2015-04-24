using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Permisson;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmPermissionAdd : XtraForm
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly DataRow objRow;

        public frmPermissionAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
        }

        public frmPermissionAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            objRow = row;
            DataBindding();
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var objTable = new iCafeDataEn.iCafe_PermissionDataTable();
                var objRow = objTable.NewiCafe_PermissionRow();
                objRow.PerID = Guid.NewGuid();
                objRow.PerName = txtPerName.Text;
                objRow.Descript = txtDescript.Text;
                objRow.FullPermiss = checkFullPermis.Checked;
                objRow.fc_customer = checkCustomer.Checked;
                objRow.fc_event = checkEvent.Checked;
                objRow.fc_revenue = checkRevenue.Checked;
                objRow.fc_sale = checkSale.Checked;
                objRow.fc_table = checkTable.Checked;
                objRow.fc_warehouse = checkWareHouse.Checked;
                objRow.fc_system = checkSystem.Checked;
                objTable.Rows.Add(objRow);
                var perCtrl = new PermissonController(m_objConnection, m_objSecurity);
                perCtrl.Addnew(objTable);
                XtraMessageBox.Show("Thêm chức vụ mới thành công");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void SetValue()
        {
            objRow["PerName"] = txtPerName.Text;
            objRow["Descript"] = txtDescript.Text;
            objRow["FullPermiss"] = checkFullPermis.Checked;
            objRow["fc_customer"] = checkCustomer.Checked;
            objRow["fc_event"] = checkEvent.Checked;
            objRow["fc_revenue"] = checkRevenue.Checked;
            objRow["fc_sale"] = checkSale.Checked;
            objRow["fc_table"] = checkTable.Checked;
            objRow["fc_warehouse"] = checkWareHouse.Checked;
            objRow["fc_system"] = checkSystem.Checked;
        }

        private void DataBindding()
        {
            var cctr = new PermissonController(m_objConnection, m_objSecurity);
            txtPerName.Text = objRow["PerName"].ToString();
            txtDescript.Text = objRow["Descript"].ToString();
            checkFullPermis.Checked = (bool) objRow["FullPermiss"];
            checkCustomer.Checked = (bool) objRow["fc_customer"];
            checkEvent.Checked = (bool) objRow["fc_event"];
            checkRevenue.Checked = (bool) objRow["fc_revenue"];
            checkSale.Checked = (bool) objRow["fc_sale"];
            checkTable.Checked = (bool) objRow["fc_table"];
            checkWareHouse.Checked = (bool) objRow["fc_warehouse"];
            checkSystem.Checked = (bool) objRow["fc_system"];
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var cctr = new PermissonController(m_objConnection, m_objSecurity);
                var objTable = new iCafeDataEn.iCafe_PermissionDataTable();
                var row = objTable.NewiCafe_PermissionRow();
                row.PerID = (Guid) objRow["PerID"];
                row.PerName = txtPerName.Text;
                row.Descript = txtDescript.Text;
                row.FullPermiss = checkFullPermis.Checked;
                row.fc_customer = checkCustomer.Checked;
                row.fc_event = checkEvent.Checked;
                row.fc_revenue = checkRevenue.Checked;
                row.fc_sale = checkSale.Checked;
                row.fc_table = checkTable.Checked;
                row.fc_warehouse = checkWareHouse.Checked;
                row.fc_system = checkSystem.Checked;
                objTable.Rows.Add(row);
                var perCtrl = new PermissonController(m_objConnection, m_objSecurity);
                perCtrl.Update(objTable);
                SetValue();
                XtraMessageBox.Show("Sửa thông tin chức vụ thành công");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkFullPermis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFullPermis.Checked)
            {
                checkWareHouse.Checked = true;
                checkTable.Checked = true;
                checkSystem.Checked = true;
                checkSale.Checked = true;
                checkRevenue.Checked = true;
                checkEvent.Checked = true;
                checkCustomer.Checked = true;
            }
            else
            {
                checkWareHouse.Checked = false;
                checkTable.Checked = false;
                checkSystem.Checked = false;
                checkSale.Checked = false;
                checkRevenue.Checked = false;
                checkEvent.Checked = false;
                checkCustomer.Checked = false;
            }
        }
    }
}