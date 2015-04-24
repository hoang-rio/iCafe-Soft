using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using iCafe.Userform;
using iCafeLIB.Controller.Food;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Security;

namespace iCafe.UserControls
{
    public partial class ucMenu : XtraUserControl
    {
        private readonly ImageCollection ic = new ImageCollection();
        private readonly SqlConnection mobjConnection;
        private readonly SecurityContext mobjSecurity;
        private DataTable objFgTable;
        private DataTable objFTable;

        public ucMenu(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            mobjConnection = objConnection;
            mobjSecurity = objSecurityContext;
            if (mobjSecurity._fc_warehouse)
            {
                InitializeComponent();
                ucBaseController1.PressClose += this_Close;
                ucBaseController1.PressNew += Add_Click;
                ucBaseController1.PressDelete += Delete_Click;
                ucBaseController1.PressRefresh += Refresh_Click;
                ucSimpleControl1.btnThemmoi.ItemClick += Add_Food_Click;
                ucSimpleControl1.btnEdit.ItemClick += Edit_Food_Click;
                ucSimpleControl1.btnFXoa.ItemClick += Delete_Food_Click;
                ucBaseController1.PressEdit += Edit_FoodGroup_Click;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {
            FillListbox();
            listFGroup.Click += FillFoodByFGrname;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            FillListbox();
        }

        private void FillListbox()
        {
            listFGroup.Items.Clear();
            Image nullImage = new Bitmap(32, 32);
            ic.ImageSize = new Size(25, 25);
            ic.AddImage(nullImage);
            var fgrController = new FoodGroupController(mobjConnection, mobjSecurity);
            try
            {
                objFgTable = fgrController.GetAll();
                for (var j = 0; j < objFgTable.Rows.Count; j++)
                {
                    var img = (Bitmap) ImageController.ConvertByteToImage((byte[]) objFgTable.Rows[j]["FGImage"]);
                    ic.AddImage(img);
                    listFGroup.Items.Add(objFgTable.Rows[j]["FGrName"].ToString());
                }
                listFGroup.ImageList = ic;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, exception.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void this_Close(object sender, EventArgs args)
        {
            Dispose();
        }

        private void FillFoodByFGrname(object sender, EventArgs args)
        {
            var fController = new FoodController(mobjConnection, mobjSecurity);
            try
            {
                if (listFGroup.Items != null)
                {
                    objFTable = fController.GetFoodByFGrName(listFGroup.SelectedItem.ToString());
                    gridControl2.DataSource = objFTable;
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Đã có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var fgAdd = new frmFoodGroupAdd(mobjConnection, mobjSecurity);
            fgAdd.ShowDialog();
            FillListbox();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var fGroupController = new FoodGroupController(mobjConnection, mobjSecurity);
                objFgTable = fGroupController.GetAll();
                var FGroupID = "" + objFgTable.Rows[listFGroup.SelectedIndex]["FGroupID"];
                fGroupController.Delete(FGroupID);
                XtraMessageBox.Show("Xóa thành công");
                FillListbox();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Đã có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listFGroup_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            Brush backBrush1 = new SolidBrush(Color.FromArgb(163, 224, 148));
            Brush backBrush2 = new SolidBrush(Color.FromArgb(253, 192, 47));
            // declare field representing the text of the item being drawn
            var itemText = listFGroup.GetItemText(e.Index);

            e.Graphics.DrawImage(ic.Images[e.Index + 1], new Point(0, e.Bounds.Top));

            if ((e.State & DrawItemState.Selected) != 0)
            {
                //e.Cache.FillRectangle(backBrush2, e.Bounds);

                e.Cache.DrawString(itemText, new Font(e.Appearance.Font.Name,
                    e.Appearance.Font.Size, FontStyle.Bold), new SolidBrush(Color.Black),
                    new Rectangle(30, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height), e.Appearance.GetStringFormat());

                e.Handled = true;
                return;
            }

            e.Cache.DrawString(itemText, e.Appearance.Font, new SolidBrush(Color.Black),
                new Rectangle(30, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height), e.Appearance.GetStringFormat());
            e.Handled = true;
        }

        private void Edit_FoodGroup_Click(object sender, EventArgs e)
        {
            objFgTable = (new FoodGroupController(mobjConnection, mobjSecurity).GetAll());
            var fgEdit = new frmFoodGroupAdd(objFgTable.Rows[listFGroup.SelectedIndex], mobjConnection, mobjSecurity);
            fgEdit.ShowDialog();
        }

        private void Add_Food_Click(object sender, EventArgs e)
        {
            var foodAdd = new frmFoodAdd(objFTable, listFGroup.SelectedItem.ToString(), mobjConnection, mobjSecurity);
            foodAdd.ShowDialog();
        }

        private void Edit_Food_Click(object sender, EventArgs e)
        {
            var foodEdit = new frmFoodAdd(gridFood.GetFocusedDataRow(), mobjConnection, mobjSecurity);
            foodEdit.ShowDialog();
            FillListbox();
        }

        private void Delete_Food_Click(object sender, EventArgs e)
        {
            try
            {
                var fController = new FoodController(mobjConnection, mobjSecurity);
                var fcRow = gridFood.GetFocusedDataRow();
                fController.Delete(fcRow["FoodID"].ToString());
                XtraMessageBox.Show("Đã xóa");

                FillFoodByFGrname(sender, e);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}