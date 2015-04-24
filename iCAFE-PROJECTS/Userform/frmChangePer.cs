using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Permisson;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmChangePer : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;

        public frmChangePer(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (!mobjSecurity._fc_system)
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                Dispose();
            }
            else
            {
                InitializeComponent();
                EmployLoad();
                PerLoad();
                ucUpdate1.btnFDong.ItemClick += Close_Click;
                ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            }
        }

        private void EmployLoad()
        {
            try
            {
                var eCtrl = new EmployeeController(mobjConnection, mobjSecurity);
                lookEmploy.Properties.DataSource = eCtrl.GetAll();
                lookEmploy.Properties.DisplayMember = "FullName";
                lookEmploy.Properties.ValueMember = "FullName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void PerLoad()
        {
            try
            {
                var pCtrl = new PermissonController(mobjConnection, mobjSecurity);
                lookPermis.Properties.DataSource = pCtrl.GetAll();
                lookPermis.Properties.DisplayMember = "PerName";
                lookPermis.Properties.ValueMember = "PerName";
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
                var objTable = new iCafeDataEn.iCafe_EmployeeDataTable();
                var row = objTable.NewiCafe_EmployeeRow();
                var fcRow = lookEmploy.Properties.View.GetFocusedDataRow();
                row.EmployID = (Guid) fcRow["EmployID"];
                row.FullName = fcRow["FullName"].ToString();
                row.EmPhone = fcRow["EmPhone"].ToString();
                row.EmAddress = fcRow["EmAddress"].ToString();
                row.Dayoff = fcRow["Dayoff"].ToString();
                row.UserName = fcRow["UserName"].ToString();
                row.PassW = fcRow["PassW"].ToString();
                row.Sex = fcRow["Sex"].ToString() == "Nam" ? true : false;
                row.WSID = (Guid) fcRow["WSID"];
                row.Birthday = (DateTime) fcRow["Birthday"];
                row.PicInfo = (byte[]) fcRow["PicInfo"];
                row.NumOvertime = (Decimal) fcRow["NumOvertime"];
                row.PerID =
                    (Guid)
                        (lookPermis.Properties.GetDataSourceRowByKeyValue(lookPermis.EditValue) as DataRowView)["PerID"];
                objTable.Rows.Add(row);
                var eCtrl = new EmployeeController(mobjConnection, mobjSecurity);
                eCtrl.Update(objTable);
                XtraMessageBox.Show("Cập nhật thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void lookEmploy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                picEmploy.Image =
                    ImageController.ConvertByteToImage((byte[])
                        lookEmploy.Properties.View.GetRowCellValue(lookEmploy.Properties.View.FocusedRowHandle,
                            "PicInfo"));
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