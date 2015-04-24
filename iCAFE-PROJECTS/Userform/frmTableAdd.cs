using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;
using iCafeLIB.Controller.Zone;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmTableAdd : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly DataRow objRow;

        /// <summary>
        ///     Hàm tạo thêm mới
        /// </summary>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public frmTableAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            InitializeComponent();
            ZoneLoad();
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            groupControl1.Text = "Thêm bàn mới";
            ucUpdate1.btnFDong.ItemClick += Close_Click;
        }

        /// <summary>
        ///     Hàm tạo sửa
        /// </summary>
        /// <param name="row"></param>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public frmTableAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            objRow = row;
            InitializeComponent();
            ZoneLoad();
            txtTableName.Text = objRow["TableName"].ToString();
            lookZone.EditValue = objRow["ZoneName"].ToString();
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
        }

        /// <summary>
        ///     Fill Zone lên lookupEdit
        /// </summary>
        private void ZoneLoad()
        {
            try
            {
                var zCtrl = new ZoneController(mobjConnection, mobjSecurity);
                lookZone.Properties.DataSource = zCtrl.GetAll();
                lookZone.Properties.DisplayMember = "ZoneName";
                lookZone.Properties.ValueMember = "ZoneName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Thêm bàn mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var objTable = new iCafeDataEn.iCafe_TableDataTable();
                var row = objTable.NewiCafe_TableRow();
                row.TableID = Guid.NewGuid();
                row.TableName = txtTableName.Text;
                row.ZoneID =
                    (Guid) ((DataRowView) lookZone.Properties.GetDataSourceRowByKeyValue(lookZone.EditValue))["ZoneID"];
                objTable.Rows.Add(row);
                var tController = new TableController(mobjConnection, mobjSecurity);
                tController.AddNew(objTable);
                XtraMessageBox.Show("Thêm bàn mới thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Cập nhật thông tin bàn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var objTable = new iCafeDataEn.iCafe_TableDataTable();
                var row = objTable.NewiCafe_TableRow();
                row.TableID = (Guid) objRow["TableID"];
                row.TableName = txtTableName.Text;
                row.ZoneID =
                    (Guid) ((DataRowView) lookZone.Properties.GetDataSourceRowByKeyValue(lookZone.EditValue))["ZoneID"];
                objTable.Rows.Add(row);
                var tController = new TableController(mobjConnection, mobjSecurity);
                tController.Update(objTable);
                XtraMessageBox.Show("Cập nhật bàn thành công");
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
    }
}