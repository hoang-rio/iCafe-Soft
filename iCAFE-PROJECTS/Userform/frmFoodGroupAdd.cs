using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.Food;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmFoodGroupAdd : XtraForm
    {
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly DataRow objRow;
        private readonly OpenFileDialog openFile = new OpenFileDialog();
        private FoodGroupController fGrController;
        private iCafeDataEn.iCafe_FoodGroupDataTable objTable;

        public frmFoodGroupAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            ControlBox = false;
            ucUpdate1.btnFCapNhat.ItemClick += AddNew;
            ucUpdate1.btnFDong.ItemClick += frmClose;
            openFile.Filter = "Tập tin ảnh|*.png;*.PNG;*.jpg;*.JPG;*.bpm;*.BPM";
            StartPosition = FormStartPosition.CenterScreen;
        }

        public frmFoodGroupAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            objRow = row;
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            ControlBox = false;
            ucUpdate1.btnFCapNhat.ItemClick += Update;
            ucUpdate1.btnFDong.ItemClick += frmClose;
            openFile.Filter = "Tập tin ảnh|*.png;*.PNG;*.jpg;*.JPG;*.bpm;*.BPM";
            StartPosition = FormStartPosition.CenterScreen;
            BinddingData();
        }

        private void BinddingData()
        {
            txtFGrName.Text = objRow["FGrName"].ToString();
            txtFGrDescript.Text = objRow["FGDescript"].ToString();
            ptbImage.Image = ImageController.ConvertByteToImage((byte[]) objRow["FGImage"]);
        }

        private void SetValue(iCafeDataEn.iCafe_FoodGroupRow row)
        {
            objRow["FGrName"] = row.FGrName;
            objRow["FGDescript"] = row.FGDescript;
            objRow["FGImage"] = row.FGImage;
        }

        private void frmClose(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AddNew(object sender, EventArgs e)
        {
            try
            {
                if (openFile.FileName == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn ảnh đại diện cho nhóm món");
                }
                else
                {
                    fGrController = new FoodGroupController(mobjConnection, mobjSecurity);
                    objTable = new iCafeDataEn.iCafe_FoodGroupDataTable();
                    var row = objTable.NewiCafe_FoodGroupRow();
                    row.FGroupID = Guid.NewGuid();
                    row.FGrName = txtFGrName.Text;
                    row.FGDescript = txtFGrDescript.Text;
                    row.FGImage = ImageController.ConvertImageToByte(openFile.FileName, new Size(48, 48),
                        ImageFormat.Png);
                    objTable.Rows.Add(row);
                    fGrController.AddNew(objTable);
                    XtraMessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Đã xuất hiện lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbtnOpenImg_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ptbImage.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void Update(object sender, EventArgs e)
        {
            try
            {
                var fgController = new FoodGroupController(mobjConnection, mobjSecurity);
                var objFgTable = new iCafeDataEn.iCafe_FoodGroupDataTable();
                var row = objFgTable.NewiCafe_FoodGroupRow();
                row.FGroupID = (Guid) objRow["FGroupID"];
                row.FGrName = txtFGrName.Text;
                row.FGDescript = txtFGrDescript.Text;
                if (openFile.FileName != "")
                {
                    row.FGImage = ImageController.ConvertImageToByte(openFile.FileName, new Size(48, 48),
                        ImageFormat.Png);
                }
                else
                {
                    row.FGImage = (byte[]) objRow["FGImage"];
                }

                objFgTable.Rows.Add(row);
                fgController.Update(objFgTable);
                SetValue(row);
                XtraMessageBox.Show("Sửa thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}