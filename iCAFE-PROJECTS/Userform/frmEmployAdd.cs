using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Employee;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Permisson;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmEmployAdd : XtraForm
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly DataRow objRow;
        private readonly string perName = "";
        private readonly string wsName = "";
        private DataTable PerTable;
        private DataTable WSTable;

        public frmEmployAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            //groupControl1.Text = "Thêm nhân viên mới";
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
            Load_Permission();
            Load_WorkShift();
        }

        public frmEmployAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            //groupControl1.Text = "Sửa thông tin nhân viên";
            objRow = row;
            Load_Permission();
            Load_WorkShift();
            perName = objRow["PerName"].ToString();
            wsName = objRow["WSName"].ToString();
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
            txtUserName.Properties.ReadOnly = true;
            txtPassW.Properties.ReadOnly = true;
        }

        private void this_Close(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Load_Permission()
        {
            try
            {
                var perController = new PermissonController(m_objConnection, m_objSecurity);
                PerTable = perController.GetAll();
                lookPermis.Properties.DataSource = PerTable;
                lookPermis.Properties.DisplayMember = "PerName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Load_WorkShift()
        {
            try
            {
                var WSController = new WorkShiftController(m_objConnection, m_objSecurity);
                WSTable = WSController.GetAll();
                lookWorkShift.Properties.DataSource = WSTable;
                lookWorkShift.Properties.DisplayMember = "WSName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (picEmployee.Image == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn ảnh đại diện cho nhân viên");
                }
                else
                {
                    var cctr = new EmployeeController(m_objConnection, m_objSecurity);
                    var objEmTable = new iCafeDataEn.iCafe_EmployeeDataTable();
                    var objEmRow = (iCafeDataEn.iCafe_EmployeeRow) objEmTable.NewRow();
                    objEmRow.EmployID = Guid.NewGuid();
                    objEmRow.FullName = txtEmployName.Text;
                    objEmRow.UserName = txtUserName.Text;
                    objEmRow.PassW = txtPassW.Text;
                    objEmRow.EmPhone = txtEmployPhone.Text;
                    objEmRow.EmAddress = txtEmployAddress.Text;
                    objEmRow.Sex = cbSex.SelectedIndex == 0 ? true : false;
                    objEmRow.Birthday = dateNS.DateTime;
                    objEmRow.PerID = (Guid) PerTable.Rows[lookPermis.ItemIndex]["PerID"];
                    objEmRow.WSID = (Guid) WSTable.Rows[lookWorkShift.ItemIndex]["WSID"];
                    objEmRow.NumOvertime = spinOvertime.Value;
                    objEmRow.Dayoff = cbDayoff.Text;
                    objEmRow.PicInfo = ImageController.ConvertImageToByte(openFileDialog1.FileName, new Size(48, 48),
                        ImageFormat.Png);
                    objEmTable.Rows.Add(objEmRow);
                    cctr.AddNew(objEmTable);
                    XtraMessageBox.Show("Thêm nhân viên mới thành công");
                }
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
                var cctr = new EmployeeController(m_objConnection, m_objSecurity);
                var objEmTable = new iCafeDataEn.iCafe_EmployeeDataTable();
                var objEmRow = (iCafeDataEn.iCafe_EmployeeRow) objEmTable.NewRow();
                objEmRow.EmployID = (Guid) objRow["EmployID"];
                objEmRow.FullName = txtEmployName.Text;
                objEmRow.UserName = txtUserName.Text;
                objEmRow.PassW = txtPassW.Text;
                objEmRow.EmPhone = txtEmployPhone.Text;
                objEmRow.EmAddress = txtEmployAddress.Text;
                objEmRow.Sex = cbSex.SelectedIndex == 0 ? true : false;
                objEmRow.Birthday = dateNS.DateTime;
                objEmRow.PerID = (Guid) PerTable.Rows[lookPermis.ItemIndex]["PerID"];
                objEmRow.WSID = (Guid) WSTable.Rows[lookPermis.ItemIndex]["WSID"];
                objEmRow.NumOvertime = spinOvertime.Value;
                objEmRow.Dayoff = cbDayoff.Text;
                if (openFileDialog1.FileName != "")
                    objEmRow.PicInfo = ImageController.ConvertImageToByte(openFileDialog1.FileName);
                else
                    objEmRow.PicInfo = (byte[]) objRow["PicInfo"];
                objEmTable.Rows.Add(objEmRow);
                cctr.Update(objEmTable);
                objRow["PicInfo"] = objEmRow.PicInfo;
                SetValue();
                XtraMessageBox.Show("Sửa thông tin nhân viên thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void SetValue()
        {
            objRow["FullName"] = txtEmployName.Text;
            objRow["UserName"] = txtUserName.Text;
            objRow["PassW"] = txtPassW.Text;
            objRow["EmPhone"] = txtEmployPhone.Text;
            objRow["EmAddress"] = txtEmployAddress.Text;
            objRow["Sex"] = cbSex.SelectedItem.ToString();
            objRow["Birthday"] = dateNS.DateTime;
            objRow["PerName"] = lookPermis.Text;
            objRow["WSName"] = lookWorkShift.Text;
            objRow["NumOvertime"] = spinOvertime.Value;
            objRow["Dayoff"] = cbDayoff.Text;
        }

        private void DataBindding()
        {
            txtEmployName.Text = objRow["FullName"].ToString();
            txtUserName.Text = objRow["UserName"].ToString();
            txtPassW.Text = objRow["PassW"].ToString();
            txtEmployPhone.Text = objRow["EmPhone"].ToString();
            txtEmployAddress.Text = objRow["EmAddress"].ToString();
            cbSex.Text = objRow["Sex"].ToString();
            dateNS.DateTime = (DateTime) objRow["Birthday"];
            spinOvertime.Value = Decimal.Parse(objRow["NumOvertime"].ToString());
            cbDayoff.Text = objRow["Dayoff"].ToString();
            if (objRow["PicInfo"] != DBNull.Value)
                picEmployee.Image = ImageController.ConvertByteToImage((byte[]) objRow["PicInfo"]);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picEmployee.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmEmployAdd_Load(object sender, EventArgs e)
        {
            if (objRow != null)
            {
                DataBindding();
            }
            if (perName != "")
            {
                lookPermis.Text = perName;
            }
            if (wsName != "")
            {
                lookWorkShift.Text = wsName;
            }
        }

        private void bbtnEditCa_Click(object sender, EventArgs e)
        {
            var ws = new frmWorkShiftAdd(m_objConnection, m_objSecurity);
            ws.ShowDialog();
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassW.Properties.PasswordChar = '\0';
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassW.Properties.PasswordChar = '*';
        }
    }
}