using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;
using iCafeLIB.Controller.Zone;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.Userform
{
    public partial class frmZoneAdd : XtraForm
    {
        private readonly DXErrorProvider error = new DXErrorProvider();
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly DataTable mobjZTable;
        private readonly iCafeDataEn.iCafe_TableDataTable objTTable = new iCafeDataEn.iCafe_TableDataTable();
        //Bảng để lưu trữ bàn

        private readonly DataRow objZRow;
        private readonly OpenFileDialog openFile = new OpenFileDialog();
        private readonly Guid ZoneID;
        private DataTable objTable_EditMode = new DataTable();

        /// <summary>
        ///     Hàm tạo để thêm mới
        /// </summary>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public frmZoneAdd(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            gridControl1.DataSource = objTTable;
            ucUpdate1.btnFCapNhat.ItemClick += AddZone_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            btnAddTable.Click += AddTable_Click;
            btnRemoveTable.Click += RemoveTable_Click;
            ZoneID = Guid.NewGuid();
            openFile.Filter = "Tập tin ảnh|*.png;*.PNG;*.jpg;*.JPG;*.bpm;*.BPM";
        }

        /// <summary>
        ///     Hàm tạo để sửa khu vực
        /// </summary>
        /// <param name="objRow"></param>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public frmZoneAdd(DataRow objRow, SqlConnection objConnection,
            SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            ucUpdate1.btnFCapNhat.ItemClick += UpdateZone_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            btnAddTable.Click += AddTable_CSDL_Click;
            btnRemoveTable.Click += RemoveTable_CSDL_Click;
            objZRow = objRow;
            ZoneID = (Guid) objZRow["ZoneID"];
            BinddingData();
            GetTableByZone();
            gridControl1.DataSource = objTable_EditMode;
            openFile.Filter = "Tập tin ảnh|*.png;*.PNG;*.jpg;*.JPG;*.bpm;*.BPM";
        }

        /// <summary>
        ///     Hàm tạo Add Zone từ grid
        /// </summary>
        /// <param name="objTable"></param>
        /// <param name="objConnection"></param>
        /// <param name="objSecurityContext"></param>
        public frmZoneAdd(DataTable objTable, SqlConnection objConnection,
            SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            ucUpdate1.btnFCapNhat.ItemClick += AddZone_Grid_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            btnAddTable.Click += AddTable_Click;
            btnRemoveTable.Click += RemoveTable_Click;
            mobjZTable = objTable;
            ZoneID = Guid.NewGuid();
            GetTableByZone();
            gridControl1.DataSource = objTTable;
            openFile.Filter = "Tập tin ảnh|*.png;*.PNG;*.jpg;*.JPG;*.bpm;*.BPM";
        }

        private void BinddingData()
        {
            try
            {
                txtZoneName.Text = objZRow["ZoneName"].ToString();
                spinCost.Value = (Decimal) objZRow["ZoneCost"];
                picZoneImage.Image = ImageController.ConvertByteToImage((byte[]) objZRow["ZoneImage"]);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Cập nhật thông tin khu vực
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateZone_Click(object sender, EventArgs e)
        {
            try
            {
                var objZTable = new iCafeDataEn.iCafe_ZoneDataTable();
                var row = objZTable.NewiCafe_ZoneRow();
                row.ZoneID = ZoneID;
                row.ZoneName = txtZoneName.Text;
                row.ZoneCost = spinCost.Value;
                if (openFile.FileName != "")
                {
                    row.ZoneImage = ImageController.ConvertImageToByte(openFile.FileName);
                }
                else
                {
                    row.ZoneImage = (byte[]) objZRow["ZoneImage"];
                }
                objZTable.Rows.Add(row);
                //-------------------------------------///
                var zController = new ZoneController(mobjConnection, mobjSecurity);
                zController.Update(objZTable);
                XtraMessageBox.Show("Cập nhật thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Thêm bàn mới vào khu vực
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTableName.Text == "")
                {
                    error.SetError(txtTableName, "Vui lòng nhập tên bàn");
                }
                else
                {
                    var row = objTTable.NewiCafe_TableRow();
                    row.TableID = Guid.NewGuid();
                    row.TableName = txtTableName.Text;
                    row.ZoneID = ZoneID;
                    objTTable.Rows.Add(row);
                    txtTableName.Text = String.Empty;
                    error.ClearErrors();
                    groupTable.Text = "Cập nhật bàn (Số bàn: " + gridView1.RowCount + ")";
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Thêm bảng mới ở chế độ sửa khu vực
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTable_CSDL_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTableName.Text == "")
                {
                    error.SetError(txtTableName, "Vui lòng nhập tên bàn");
                }
                else
                {
                    var objlocalTable = new iCafeDataEn.iCafe_TableDataTable();
                    var row = objlocalTable.NewiCafe_TableRow();
                    row.TableID = Guid.NewGuid();
                    row.TableName = txtTableName.Text;
                    row.ZoneID = ZoneID;
                    objlocalTable.Rows.Add(row);
                    objTable_EditMode.ImportRow(row);
                    txtTableName.Text = String.Empty;
                    error.ClearErrors();
                    //--------------------------------------------------------//
                    var tController = new TableController(mobjConnection, mobjSecurity);
                    tController.AddNew(objlocalTable);
                    groupTable.Text = "Cập nhật bàn (Số bàn: " + gridView1.RowCount + ")";
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Xóa bàn đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveTable_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
            groupTable.Text = "Cập nhật bàn (Số bàn: " + gridView1.RowCount + ")";
        }

        private void RemoveTable_CSDL_Click(object sender, EventArgs e)
        {
            try
            {
                var tController = new TableController(mobjConnection, mobjSecurity);
                tController.Delete(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TableID").ToString());
                gridView1.DeleteSelectedRows();
                groupTable.Text = "Cập nhật bàn (Số bàn: " + gridView1.RowCount + ")";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        /// <summary>
        ///     Thêm khu vực mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddZone_Click(object sender, EventArgs e)
        {
            try
            {
                var objZTable = new iCafeDataEn.iCafe_ZoneDataTable();
                var row = objZTable.NewiCafe_ZoneRow();
                row.ZoneID = ZoneID;
                row.ZoneName = txtZoneName.Text;
                row.ZoneCost = spinCost.Value;
                row.ZoneImage = ImageController.ConvertImageToByte(openFile.FileName, new Size(48, 48), ImageFormat.Png);
                objZTable.Rows.Add(row);
                //-------------------------------------------------------//
                var zCtrl = new ZoneController(mobjConnection, mobjSecurity);
                var tCtrl = new TableController(mobjConnection, mobjSecurity);
                zCtrl.AddNew(objZTable);
                tCtrl.AddNew(objTTable);
                XtraMessageBox.Show("Thêm thành công");
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void AddZone_Grid_Click(object sender, EventArgs e)
        {
            try
            {
                var objZTable = new iCafeDataEn.iCafe_ZoneDataTable();
                var row = objZTable.NewiCafe_ZoneRow();
                row.ZoneID = ZoneID;
                row.ZoneName = txtZoneName.Text;
                row.ZoneCost = spinCost.Value;
                row.ZoneImage = ImageController.ConvertImageToByte(openFile.FileName, new Size(48, 48), ImageFormat.Png);
                objZTable.Rows.Add(row);
                //-------------------------------------------------------//
                var zCtrl = new ZoneController(mobjConnection, mobjSecurity);
                var tCtrl = new TableController(mobjConnection, mobjSecurity);
                zCtrl.AddNew(objZTable);
                tCtrl.AddNew(objTTable);
                XtraMessageBox.Show("Thêm thành công");
                mobjZTable.ImportRow(row);
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
                picZoneImage.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GetTableByZone()
        {
            try
            {
                var tController = new TableController(mobjConnection, mobjSecurity);
                objTable_EditMode = tController.GetByZoneName(txtZoneName.Text);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}