using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using iCafe.Properties;
using iCafe.Userform;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;
using iCafeLIB.Controller.Zone;

namespace iCafe.UserControls
{
    public partial class ucBookTable : XtraUserControl
    {
        private readonly SecurityContext m_objSecurity;
        private readonly SqlConnection m_objSQLConn;
        private int c;
        private ListView[] listViews;
        private DataTable objZoneTable;

        public ucBookTable(SqlConnection objConnect, SecurityContext objSecurity)
        {
            m_objSQLConn = objConnect;
            m_objSecurity = objSecurity;
            if (m_objSecurity._fc_table)
            {
                InitializeComponent();
                LoadTable();
                ucSimpleControl1.btnThemmoi.ItemClick += AddZone_Click;
                ucSimpleControl1.btnEdit.ItemClick += EditZone_Click;
                ucSimpleControl1.btnFXoa.ItemClick += DeleteZone_Click;
                ucBaseController2.PressNew += Add_BookTable_Click;
                ucBaseController2.PressEdit += Edit_BookTable_Click;
                ucBaseController2.PressClose += Close_Click;
                ucBaseController2.PressDelete += Delete_Click;
                ucBaseController2.PressSearch += Search_Click;
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                var sBox = new frmSearchBox(0, m_objSQLConn, m_objSecurity);
                sBox.Text = "Tìm theo tên khách hàng";
                sBox.ShowDialog();
                var CusName = sBox.txtkeyWord.Text;
                if (CusName != "")
                {
                    SplashScreenManager.ShowForm(typeof(frmwait));
                    var btController = new BookTableController(m_objSQLConn, m_objSecurity);
                    gridControl1.DataSource = btController.GetByCusName(CusName);
                    SplashScreenManager.CloseForm();
                }               
                sBox.Dispose();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void Add_BookTable_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                var selectedTabIndex = tabTable1.SelectedTabPageIndex;
                var itemIndex = 0;
                try
                {
                    itemIndex = listViews[selectedTabIndex].SelectedIndices[0];
                }
                catch (Exception)
                {
                }
                var bookTableAdd = new frmBookTableAdd(tabTable1.SelectedTabPage.Text,
                    listViews[selectedTabIndex].Items[itemIndex].Text,listViews[tabTable1.SelectedTabPageIndex], m_objSQLConn, m_objSecurity);
                bookTableAdd.ShowDialog();
                GetBookTableByTableID(listViews[selectedTabIndex].Items[itemIndex].Name);
                tabTable1.SelectedTabPageIndex = selectedTabIndex;
                SplashScreenManager.CloseForm();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void LoadTable()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                tabTable1.TabPages.Clear();
                var btController = new BookTableController(m_objSQLConn, m_objSecurity);
                var zCtrl = new ZoneController(m_objSQLConn, m_objSecurity);
                var tbController = new TableController(m_objSQLConn, m_objSecurity);
                objZoneTable = zCtrl.GetAll();
                c = objZoneTable.Rows.Count;
                var tabPages = new XtraTabPage[c];
                listViews = new ListView[c];
                imgList.Images.Clear();
                imgList.Images.Add(Resources.clock);
                imgList.ImageSize = new Size(48, 48);
                for (var i = 0; i < c; i++)
                {
                    tabPages[i] = new XtraTabPage();
                    tabPages[i].Name = objZoneTable.Rows[i]["ZoneName"].ToString();
                    tabPages[i].Text = objZoneTable.Rows[i]["ZoneName"].ToString();
                    tabTable1.TabPages.Add(tabPages[i]);
                    var img = ImageController.ConvertByteToImage((byte[]) objZoneTable.Rows[i]["ZoneImage"]);
                    var objTable = tbController.GetByZoneName(tabPages[i].Text);
                    imgList.Images.Add(img);
                    listViews[i] = new ListView();
                    listViews[i].LargeImageList = imgList;
                    var items = new ListViewItem[objTable.Rows.Count];
                    for (var j = 0; j < objTable.Rows.Count; j++)
                    {
                        items[j] = new ListViewItem();
                        items[j].Text = objTable.Rows[j]["TableName"].ToString();
                        items[j].Name = objTable.Rows[j]["TableID"].ToString();
                        if (btController.GetByTableID(objTable.Rows[j]["TableID"].ToString()).Rows.Count != 0)
                        {
                            items[j].ImageIndex = 0;
                        }
                        else
                        {
                            items[j].ImageIndex = i + 1;
                        }
                    }
                    listViews[i].MultiSelect = false;
                    listViews[i].Items.AddRange(items);
                    listViews[i].Dock = DockStyle.Fill;
                    tabTable1.TabPages[i].Controls.Add(listViews[i]);
                    listViews[i].ItemSelectionChanged += ListViewSelectionChange;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ListViewSelectionChange(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            GetBookTableByTableID(e.Item.Name);
        }

        private void GetBookTableByTableID(string tableID)
        {
            try
            {
                DataTable objBookTable;
                var btController = new BookTableController(m_objSQLConn, m_objSecurity);
                objBookTable = btController.GetByTableID(tableID);
                gridControl1.DataSource = objBookTable;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }

        private void ucBookTable_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
        private void tabTable1_Click(object sender, EventArgs e)
        {
            try
            {
                var i = tabTable1.SelectedTabPageIndex;
                var tableid = listViews[i].Items[0].Name;
                listViews[i].Items[0].Selected = true;
                listViews[i].Select();
                GetBookTableByTableID(tableid);
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

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    XtraMessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var btController = new BookTableController(m_objSQLConn, m_objSecurity);
                    btController.Delete(
                        gridBookTable.GetRowCellValue(gridBookTable.FocusedRowHandle, "BTableID").ToString());                    
                    if (gridBookTable.RowCount == 1)
                    {
                        listViews[tabTable1.SelectedTabPageIndex].Items[
                            gridBookTable.GetRowCellValue(gridBookTable.FocusedRowHandle, "TableID").ToString()]
                            .ImageIndex = tabTable1.SelectedTabPageIndex + 1;
                    }
                    gridBookTable.DeleteSelectedRows();
                    XtraMessageBox.Show("Xóa thành công");
                    //tabTable1_Click(sender, null);
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi.Chi tiết: " + exception.Message);
            }
        }

        private void AddZone_Click(object sender, EventArgs e)
        {
            var zAdd = new frmZoneAdd(m_objSQLConn, m_objSecurity);
            zAdd.ShowDialog();
            LoadTable();
        }

        private void EditZone_Click(object sender, EventArgs e)
        {
            var zEdit = new frmZoneAdd(objZoneTable.Rows[tabTable1.SelectedTabPageIndex], m_objSQLConn, m_objSecurity);
            zEdit.ShowDialog();
            LoadTable();
        }

        private void DeleteZone_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    XtraMessageBox.Show("Bạn chắc chắn muốn xóa?", "Hỏi", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var zController = new ZoneController(m_objSQLConn, m_objSecurity);
                    zController.Delete(objZoneTable.Rows[tabTable1.SelectedTabPageIndex]["ZoneID"].ToString());
                    XtraMessageBox.Show("Xóa thành công");
                    LoadTable();
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết" + exception.Message);
            }
        }

        private void Edit_BookTable_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                if (gridBookTable.RowCount > 0)
                {
                    var BTEdit = new frmBookTableAdd(gridBookTable.GetFocusedDataRow(), m_objSQLConn, m_objSecurity);
                    BTEdit.ShowDialog();
                }
                SplashScreenManager.CloseForm();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("Đã có lỗi. Chi tiết: " + exception.Message);
            }
        }
    }
}