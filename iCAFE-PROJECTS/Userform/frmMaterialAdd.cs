using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Material;
using iCafeLIB.Controller.Security;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmMaterialAdd : XtraForm
    {
        private readonly SqlConnection m_objConnection;
        private readonly SecurityContext m_objSecurity;
        private readonly DataRow objRow;

        public frmMaterialAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            ucUpdate1.btnFCapNhat.ItemClick += Add_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        public frmMaterialAdd(DataRow row, SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            m_objConnection = objConnection;
            m_objSecurity = objSecurityContext;
            objRow = row;
            DataBindding();
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            ucUpdate1.btnFDong.ItemClick += this_Close;
        }

        private void this_Close(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (picMaterial.Image == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn ảnh đại diện cho nguyên liệu");
                }
                else
                {
                    var cctr = new RawMaterialController(m_objConnection, m_objSecurity);
                    var objMaterialTable = new iCafeDataEn.iCafe_RawMaterialDataTable();
                    var objMaterialRow = (iCafeDataEn.iCafe_RawMaterialRow) objMaterialTable.NewRow();
                    objMaterialRow.RMID = Guid.NewGuid();
                    objMaterialRow.RMName = txtRMName.Text;
                    objMaterialRow.Quantity = Convert.ToInt32(txtQuantity.Text);
                    objMaterialRow.Unit = txtUnit.Text;
                    objMaterialRow.Descript = txtDescript.Text;
                    objMaterialRow.RMPrice = Decimal.Parse(txtRMPrice.Text);
                    objMaterialRow.PicInfo = ImageController.ConvertImageToByte(openFileDialog1.FileName,
                        new Size(48, 48), ImageFormat.Png);
                    objMaterialTable.Rows.Add(objMaterialRow);

                    cctr.AddNew(objMaterialTable);
                    XtraMessageBox.Show("Thêm nguyên liệu mới thành công");
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void SetValue()
        {
            objRow["RMName"] = txtRMName.Text;
            objRow["Quantity"] = Convert.ToInt32(txtQuantity.Text);
            objRow["Unit"] = txtUnit.Text;
            objRow["Descript"] = txtDescript.Text;
            objRow["RMPrice"] = txtRMPrice.Text;
            if (openFileDialog1.FileName != "")
                objRow["PicInfo"] = ImageController.ConvertImageToByte(openFileDialog1.FileName);
            else
                objRow["PicInfo"] = (byte[]) objRow["PicInfo"];
        }

        private void DataBindding()
        {
            var cctr = new RawMaterialController(m_objConnection, m_objSecurity);
            txtRMName.Text = objRow["RMName"].ToString();
            txtQuantity.Text = objRow["Quantity"].ToString();
            txtUnit.Text = objRow["Unit"].ToString();
            txtDescript.Text = objRow["Descript"].ToString();
            txtRMPrice.Text = objRow["RMPrice"].ToString();
            if (objRow["PicInfo"] != DBNull.Value)
                picMaterial.Image = ImageController.ConvertByteToImage((byte[]) objRow["PicInfo"]);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var cctr = new RawMaterialController(m_objConnection, m_objSecurity);
                var objMaterialTable = new iCafeDataEn.iCafe_RawMaterialDataTable();
                var objMaterialRow = (iCafeDataEn.iCafe_RawMaterialRow) objMaterialTable.NewRow();
                objMaterialRow.RMID = (Guid) objRow["RMID"];
                objMaterialRow.RMName = txtRMName.Text;
                objMaterialRow.Quantity = Convert.ToInt32(txtQuantity.Text);
                objMaterialRow.Unit = txtUnit.Text;
                objMaterialRow.Descript = txtDescript.Text;
                if (openFileDialog1.FileName != "")
                    objMaterialRow.PicInfo = ImageController.ConvertImageToByte(openFileDialog1.FileName);
                else
                    objMaterialRow.PicInfo = (byte[]) objRow["PicInfo"];
                objMaterialRow.PicInfo = objMaterialRow.PicInfo;
                objMaterialRow.RMPrice = Decimal.Parse(txtRMPrice.Text);
                objMaterialTable.Rows.Add(objMaterialRow);
                cctr.Update(objMaterialTable);
                SetValue();
                XtraMessageBox.Show("Sửa thông tin nguyên liệu thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnOpenIMG_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picMaterial.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}