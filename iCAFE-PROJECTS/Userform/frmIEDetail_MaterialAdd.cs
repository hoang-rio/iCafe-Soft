using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Material;
using iCafeLIB.Controller.Security;

namespace iCafe.Userform
{
    public partial class frmIEDetail_MaterialAdd : XtraForm
    {
        public delegate void getToTal(decimal Total);

        private readonly DataColumnCollection columns;
        private readonly Guid IEID;
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private readonly DataTable objDetailTable = new DataTable();
        public getToTal getTotalValue;
        private DataRow objDTRow;
        private DataTable objMaterialTable;

        public frmIEDetail_MaterialAdd(DataTable objTable, Guid objIEID, SqlConnection objConnection,
            SecurityContext objSecurityContext)
        {
            InitializeComponent();
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            objDetailTable = objTable;
            IEID = objIEID;
            Material_Load();
            ucUpdate1.btnFCapNhat.ItemClick += Add_Material_Click;
            ucUpdate1.btnFDong.ItemClick += Close_Click;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Add_Material_Click(object sender, EventArgs e)
        {
            try
            {
                var view = lookMaterial.Properties.View;
                var material = view.GetRowCellValue(view.FocusedRowHandle, "RMName").ToString();
                if (objDetailTable.Rows.Count > 0)
                {
                    foreach (DataRow erow in objDetailTable.Rows)
                    {
                        if (string.Compare(erow["RMName"].ToString(), material) == 0)
                        {
                            erow["Quantity"] = (Decimal) erow["Quantity"] + spinQuantity.Value;
                            erow["TotalPrice"] = (Decimal) erow["Quantity"]*(Decimal) erow["RMPrice"];
                            material = "";
                        }
                    }
                }
                if (material != "")
                {
                    objDTRow = objDetailTable.NewRow();
                    objDTRow["IEID"] = IEID;
                    objDTRow["RMID"] = (Guid) view.GetRowCellValue(view.FocusedRowHandle, "RMID");
                    objDTRow["Quantity"] = spinQuantity.Value;
                    objDTRow["RMName"] = view.GetRowCellValue(view.FocusedRowHandle, "RMName");
                    objDTRow["Unit"] = view.GetRowCellValue(view.FocusedRowHandle, "Unit");
                    objDTRow["RMPrice"] = view.GetRowCellValue(view.FocusedRowHandle, "RMPrice");
                    objDTRow["ImportDate"] = dateImportDate.DateTime;
                    objDTRow["ExpireDate"] = dateExpireDate.DateTime;
                    objDTRow["DetailNote"] = txtDetailNote.Text;
                    objDTRow["TotalPrice"] = (spinQuantity.Value*
                                              (Decimal) view.GetRowCellValue(view.FocusedRowHandle, "RMPrice"));
                    objDetailTable.Rows.Add(objDTRow);
                }
                if (getTotalValue != null)
                {
                    decimal value = 0;
                    foreach (DataRow row in objDetailTable.Rows)
                    {
                        value += Decimal.Parse(row["TotalPrice"].ToString());
                    }
                    getTotalValue(value);
                }
                Text = "Thêm thành công";
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Material_Load()
        {
            objMaterialTable = new RawMaterialController(mobjConnection, mobjSecurity).GetALL();
            lookMaterial.Properties.DataSource = objMaterialTable;
            lookMaterial.Properties.DisplayMember = "RMName";
        }

        private void lookMaterial_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                picMaterial.Image =
                    ImageController.ConvertByteToImage(
                        (byte[])
                            lookMaterial.Properties.View.GetRowCellValue(lookMaterial.Properties.View.FocusedRowHandle,
                                "PicInfo"));
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}