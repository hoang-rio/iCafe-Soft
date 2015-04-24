using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;
using iCafeLIB.Controller.Zone;

namespace iCafe.UserControls
{
    public partial class ucTableByZone : XtraUserControl
    {
        private readonly SecurityContext m_objSecurity;
        private readonly SqlConnection m_objSQLConn;
        private int c;
        private ListView[] listViews;
        private DataTable objZoneTable;

        public ucTableByZone(SqlConnection objConnection, SecurityContext objSecurityContext)
        {
            m_objSQLConn = objConnection;
            m_objSecurity = objSecurityContext;
            if (!m_objSecurity._fc_table)
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
                Dispose();
            }
            else
            {
                InitializeComponent();
                LoadTable();
            }
        }

        private void LoadTable()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                tabTable1.TabPages.Clear();
                var zCtrl = new ZoneController(m_objSQLConn, m_objSecurity);
                var tbController = new TableController(m_objSQLConn, m_objSecurity);
                objZoneTable = zCtrl.GetAll();
                c = objZoneTable.Rows.Count;
                var tabPages = new XtraTabPage[c];
                listViews = new ListView[c];
                imgList.Images.Clear();
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
                        items[j].Name = objTable.Rows[j]["TableName"].ToString();

                        items[j].ImageIndex = i;
                    }
                    listViews[i].Items.AddRange(items);
                    listViews[i].Dock = DockStyle.Fill;
                    tabTable1.TabPages[i].Controls.Add(listViews[i]);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}