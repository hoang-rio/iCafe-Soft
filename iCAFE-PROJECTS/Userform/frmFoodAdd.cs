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
    public partial class frmFoodAdd : XtraForm
    {
        private readonly string foodGrName = "";
        private readonly SqlConnection mobjConnection;
        private readonly DataTable mobjFTable;
        private readonly SecurityContext mobjSecurity;
        private readonly DataRow objRow;
        private readonly OpenFileDialog openFile = new OpenFileDialog();
        private DataTable objFgTable;

        public frmFoodAdd(DataTable objTable, string foodGroupName, SqlConnection objConnection,
            SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            foodGrName = foodGroupName;
            mobjFTable = objTable;
            openFile.Filter = "Tập tin ảnh|*.png;*.PNG;*.jpg;*.JPG;*.bpm;*.BPM";
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            GetFoodGroup();
        }

        public frmFoodAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            objRow = row;
            openFile.Filter = "Tập tin ảnh|*.png;*.PNG;*.jpg;*.JPG;*.bpm;*.BPM";
            GetFoodGroup();
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var objFTable = new iCafeDataEn.iCafe_FoodDataTable();
                var row = objFTable.NewiCafe_FoodRow();
                row.FoodID = Guid.NewGuid();
                row.FoodName = txtFoodName.Text;
                row.FUnit = txtUnit.Text;
                row.FPrice = Decimal.Parse(txtPrice.Text);
                row.FGroupID = (Guid) objFgTable.Rows[lookFoodGroup.ItemIndex]["FGroupID"];
                row.FImage = ImageController.ConvertImageToByte(openFile.FileName, new Size(48, 48), ImageFormat.Png);
                objFTable.Rows.Add(row);
                var fCtrl = new FoodController(mobjConnection, mobjSecurity);
                fCtrl.AddNew(objFTable);
                mobjFTable.ImportRow(row);
                XtraMessageBox.Show("Thêm thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void BindingData()
        {
            try
            {
                txtFoodName.Text = objRow["FoodName"].ToString();
                txtPrice.Text = objRow["FPrice"].ToString();
                txtUnit.Text = objRow["FUnit"].ToString();
                lookFoodGroup.Text = objRow["FGrName"].ToString();
                picFood.Image = ImageController.ConvertByteToImage((byte[]) objRow["FImage"]);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void SetValue(iCafeDataEn.iCafe_FoodRow objFRow)
        {
            try
            {
                objRow["FoodName"] = txtFoodName.Text;
                objRow["FPrice"] = txtPrice.Text;
                objRow["FUnit"] = txtUnit.Text;
                objRow["FGrName"] = lookFoodGroup.Text;
                objRow["FImage"] = objFRow.FImage;
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
                var objFTable = new iCafeDataEn.iCafe_FoodDataTable();
                var objFRow = objFTable.NewiCafe_FoodRow();
                objFRow.FoodID = (Guid) objRow["FoodID"];
                objFRow.FoodName = txtFoodName.Text;
                objFRow.FPrice = Decimal.Parse(txtPrice.Text);
                objFRow.FUnit = txtUnit.Text;
                objFRow.FGroupID = (Guid) objFgTable.Rows[lookFoodGroup.ItemIndex]["FGroupID"];
                if (openFile.FileName != "")
                {
                    objFRow.FImage = ImageController.ConvertImageToByte(openFile.FileName, new Size(48, 48),
                        ImageFormat.Png);
                }
                else
                {
                    objFRow.FImage = (byte[]) objRow["FImage"];
                }
                objFTable.Rows.Add(objFRow);
                var fController = new FoodController(mobjConnection, mobjSecurity);
                fController.Update(objFTable);
                SetValue(objFRow);
                XtraMessageBox.Show("Cập nhật thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void GetFoodGroup()
        {
            try
            {
                var fgController = new FoodGroupController(mobjConnection, mobjSecurity);
                objFgTable = fgController.GetAll();
                lookFoodGroup.Properties.DataSource = objFgTable;
                lookFoodGroup.Properties.DisplayMember = "FGrName";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void btnOpenIMG_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picFood.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void frmFoodAdd_Load(object sender, EventArgs e)
        {
            if (objRow != null)
            {
                BindingData();
            }
            if (foodGrName != "")
            {
                lookFoodGroup.Text = foodGrName;
            }
        }
    }
}