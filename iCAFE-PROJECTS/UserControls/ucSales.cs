using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using iCafe.Properties;
using iCafe.Userform;
using iCafeLIB.Controller.Customer;
using iCafeLIB.Controller.Event;
using iCafeLIB.Controller.Food;
using iCafeLIB.Controller.ImageInfo;
using iCafeLIB.Controller.Sale;
using iCafeLIB.Controller.Security;
using iCafeLIB.Controller.Table;
using iCafeLIB.Controller.Zone;
using iCafeLIB.Models.DatasetEn;

namespace iCafe.UserControls
{
    public partial class ucSales : XtraUserControl
    {
        private readonly BookTableController btController;
        private readonly CustomerController cusController;
        private readonly EventController eventController;
        private readonly FoodController fController;
        private readonly ImageCollection ic = new ImageCollection();
        private readonly ImageCollection id = new ImageCollection();
        private readonly ImageList im = new ImageList();
        private readonly SecurityContext m_objSecurity;
        private readonly SqlConnection m_objSQLConn;
        private readonly SaleController slController;
        private readonly TableController tbController;
        private readonly ZoneController zCtrl;
        public Guid BILLID;
        public Guid CusID;
        public int indextabpage1;
        public int indextabpage2;
        public ListView[] listViews;
        public Guid maban;
        public string mode = "abc";
        private DataTable objEvent = new DataTable();
        private DataTable objFgTable;
        private DataTable objSale = new DataTable();
        public string status = "";
        public int tabNum;

        public ucSales(SqlConnection objSQLConnect, SecurityContext objSecurity)
        {
            m_objSQLConn = objSQLConnect;
            m_objSecurity = objSecurity;
            im.ImageSize = new Size(48, 48);
            im.ColorDepth = ColorDepth.Depth32Bit;
            slController = new SaleController(m_objSQLConn, m_objSecurity);
            zCtrl = new ZoneController(m_objSQLConn, m_objSecurity);
            fController = new FoodController(m_objSQLConn, m_objSecurity);
            btController = new BookTableController(m_objSQLConn, m_objSecurity);
            cusController = new CustomerController(m_objSQLConn, m_objSecurity);
            tbController = new TableController(m_objSQLConn, m_objSecurity);
            eventController = new EventController(m_objSQLConn, m_objSecurity);
            if (m_objSecurity._fc_sale)
            {
                maban = new Guid();
                InitializeComponent();
            }
            else
            {
                XtraMessageBox.Show("Bạn không có quyền truy cập mục này");
            }
        }

        /// <summary>
        ///     Đưa danh mục món lên listbox
        /// </summary>
        public void TaoData()
        {
            objSale.Columns.Add("FoodName", Type.GetType("System.String"));
            objSale.Columns.Add("Quantity", Type.GetType("System.Decimal"));
            objSale.Columns.Add("FPrice", Type.GetType("System.Int32"));
            objSale.Columns.Add("TotalDiscount", Type.GetType("System.Int16"));
            objSale.Columns.Add("Price", Type.GetType("System.Int32"));
            objSale.Columns.Add("Bill_ID", Type.GetType("System.Guid"));
            objSale.Columns.Add("Value", Type.GetType("System.Int32"));
        }

        private void FillListbox()
        {
            DataTable objFgTable;
            Image nullImage = new Bitmap(48, 48);
            ic.AddImage(nullImage);
            ic.ImageSize = new Size(25, 25);
            var fgrController = new FoodGroupController(m_objSQLConn, m_objSecurity);
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

        /// <summary>
        ///     Đưa dánh món theo danh mục khi bấm listbox danh mục món
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void FillFoodByFGrname(object sender, EventArgs args)
        {
            try
            {
                imgListFood.Items.Clear();
                id.Images.Clear();
                id.ImageSize = new Size(25, 25);
                if (listFGroup.Items != null)
                {
                    objFgTable = fController.GetFoodByFGrName(listFGroup.SelectedItem.ToString());
                    for (var j = 0; j < objFgTable.Rows.Count; j++)
                    {
                        var img = (Bitmap) ImageController.ConvertByteToImage((byte[]) objFgTable.Rows[j]["FImage"]);
                        id.AddImage(img);
                        imgListFood.Items.Add(objFgTable.Rows[j]["FoodName"].ToString());
                    }
                    imgListFood.ImageList = id;
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Đã có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Listview_DropDrag(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof (ListView.SelectedListViewItemCollection)))
                if (e.Effect == DragDropEffects.Copy)
                {
                    foreach (
                        ListViewItem item in
                            (ListView.SelectedListViewItemCollection)
                                e.Data.GetData(typeof (ListView.SelectedListViewItemCollection)))
                    {
                    }
                }
        }

        private void FillListImage()
        {
            var objZoneTable = zCtrl.GetAll();
            im.Images.Clear();
            im.Images.Add(Resources.People_48);
            im.Images.Add(Resources.clock);
            im.Images.Add(Resources.money_48);
            for (var i = 0; i < objZoneTable.Rows.Count; i++)
            {
                var img = ImageController.ConvertByteToImage((byte[]) objZoneTable.Rows[i]["ZoneImage"]);
                im.Images.Add(img);
            }
        }

        private void FillViewImage()
        {
            try
            {
                tabZone1.TabPages.Clear();
                tabZone2.TabPages.Clear();
                var objZoneTable = zCtrl.GetAll();
                tabNum = objZoneTable.Rows.Count;
                var tabPages = new XtraTabPage[tabNum];
                listViews = new ListView[tabNum];
                for (var i = 0; i < tabNum/2; i++)
                {
                    tabPages[i] = new XtraTabPage();
                    tabPages[i].Text = objZoneTable.Rows[i]["ZoneName"].ToString();
                    tabZone1.TabPages.Add(tabPages[i]);
                    var objTable = tbController.GetByZoneName(tabPages[i].Text);
                    listViews[i] = new ListView();
                    listViews[i].LargeImageList = im;
                    var items = new ListViewItem[objTable.Rows.Count];
                    for (var j = 0; j < objTable.Rows.Count; j++)
                    {
                        items[j] = new ListViewItem();
                        items[j].Text = objTable.Rows[j]["TableName"].ToString();
                        var tTable = tbController.GetTableID(items[j].Text);
                        var billStatusTable = slController.SaleLoadFromTableID((Guid) tTable.Rows[0][0]);
                        if (billStatusTable.Rows.Count != 0)
                        {
                            mode = "1";
                            for (var l = 0; l < billStatusTable.Rows.Count; l++)
                            {
                                if (int.Parse(billStatusTable.Rows[l]["Bstatus"].ToString()) == 5)
                                {
                                    items[j].ImageIndex = 0;
                                }
                                else if (int.Parse(billStatusTable.Rows[l]["Bstatus"].ToString()) == 2)
                                {
                                    items[j].ImageIndex = 2;
                                }
                            }
                        }
                        else if (btController.GetByTableName((objTable.Rows[j]["TableName"]).ToString()).Rows.Count != 0)
                        {
                            items[j].ImageIndex = 1;
                        }
                        else
                        {
                            items[j].ImageIndex = i + 3;
                        }
                    }
                    listViews[i].Items.AddRange(items);
                    listViews[i].Dock = DockStyle.Fill;
                    listViews[i].ItemSelectionChanged += ListViewSelectionChange;
                    tabZone1.TabPages[i].Controls.Add(listViews[i]);
                }
                for (var i = tabNum/2; i < tabNum; i++)
                {
                    tabPages[i] = new XtraTabPage();
                    tabPages[i].Text = objZoneTable.Rows[i]["ZoneName"].ToString();
                    tabZone2.TabPages.Add(tabPages[i]);
                    var objTable = tbController.GetByZoneName(tabPages[i].Text);
                    listViews[i] = new ListView();
                    listViews[i].LargeImageList = im;
                    var items = new ListViewItem[objTable.Rows.Count];
                    for (var j = 0; j < objTable.Rows.Count; j++)
                    {
                        items[j] = new ListViewItem();
                        items[j].Text = objTable.Rows[j]["TableName"].ToString();
                        var tTable = tbController.GetTableID(items[j].Text);
                        var billStatusTable = slController.SaleLoadFromTableID((Guid) tTable.Rows[0][0]);
                        if (billStatusTable.Rows.Count != 0)
                        {
                            mode = "1";
                            for (var l = 0; l < billStatusTable.Rows.Count; l++)
                            {
                                if (int.Parse(billStatusTable.Rows[l]["Bstatus"].ToString()) == 5)
                                    items[j].ImageIndex = 0;
                                else if (int.Parse(billStatusTable.Rows[l]["Bstatus"].ToString()) == 2)
                                    items[j].ImageIndex = 2;
                            }
                        }
                        else if (btController.GetByTableName((objTable.Rows[j]["TableName"]).ToString()).Rows.Count != 0)
                        {
                            items[j].ImageIndex = 1;
                        }
                        else
                        {
                            items[j].ImageIndex = i + 3;
                        }
                    }
                    listViews[i].Items.AddRange(items);
                    listViews[i].Dock = DockStyle.Fill;
                    listViews[i].ItemSelectionChanged += ListViewSelectionChange;
                    tabZone2.TabPages[i - tabNum/2].Controls.Add(listViews[i]);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Thông báo:");
            }
        }

        private void ListViewSelectionChange(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            TableClick(e.Item.Text);
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            var tp = new ToolTip();
            tp.SetToolTip(rtbRunevt, rtbRunevt.Text);
            FillListbox();
            listFGroup.Click += FillFoodByFGrname;
            FillListImage();
            FillViewImage();
            Event_load();
            LoadKH();
            TaoData();
            Enable_Control(false);
        }

        private void Enable_Control(bool t)
        {
            txtPrice.Enabled = t;
            srchCustomer.Enabled = t;
            btnaddMon.Enabled = t;
            imgListFood.Enabled = t;
        }

        private void Event_load()
        {
            objEvent = eventController.GetEventNow();
            lookEvent.Properties.DataSource = objEvent;
            lookEvent.Properties.DisplayMember = "EventName";
            lookEvent.Properties.ValueMember = "EventID";
            lookEvent.ItemIndex = 0;
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

        private void imgListFood_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            Brush backBrush1 = new SolidBrush(Color.FromArgb(163, 224, 148));
            Brush backBrush2 = new SolidBrush(Color.FromArgb(253, 192, 47));
            // declare field representing the text of the item being drawn
            var itemText = imgListFood.GetItemText(e.Index);
            e.Graphics.DrawImage(id.Images[e.Index], new Point(0, e.Bounds.Top));

            if ((e.State & DrawItemState.Selected) != 0)
            {
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

        private void TableClick(string s)
        {
            SplashScreenManager.ShowForm(typeof (frmwait));
            {
                lblMoney.ResetText();
                lbltenmon.ResetText();
                txtPrice.ResetText();
                var objTable = new DataTable();
                objTable = tbController.GetTableID(s);
                maban = (Guid) objTable.Rows[0]["TableID"];
                BILLID = Guid.NewGuid();
                objSale.Rows.Clear();
                objSale = slController.SaleLoadFromTableID(maban);
                objSale.Columns.Add("ZoneCost", Type.GetType("System.Int32"));
                var ZoneCost = int.Parse(slController.GetZoneCOST(maban).Rows[0]["ZoneCost"].ToString());
                for (var i = 0; i < objSale.Rows.Count; i++)
                {
                    objSale.Rows[i]["ZoneCost"] = ZoneCost;
                }
                try
                {
                    if ((objSale.Rows.Count > 0))
                    {
                        srchCustomer.EditValue = objSale.Rows[0]["CusID"].ToString();
                        lblMoney.Text = string.Format(CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,## VNĐ}",
                            objSale.Rows[0]["AfterDiscount"]);
                        gridCDaban.DataSource = objSale;
                        if (objSale.Rows[0]["Bstatus"].ToString() == "5")
                        {
                            btnThutien.Enabled = false;
                            btnInPhieu.Enabled = true;
                        }
                        else if (objSale.Rows[0]["Bstatus"].ToString() == "2")
                        {
                            btnThutien.Enabled = true;
                            btnInPhieu.Enabled = false;
                        }
                    }
                    else
                    {
                        srchCustomer.EditValue = "62dc097d-a17b-46b0-8f96-53756f9033d9";
                        gridCDaban.DataSource = null;
                        lblMoney.Text = string.Format(CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,## VNĐ}", 0);
                        btnThutien.Enabled = false;
                        btnInPhieu.Enabled = false;
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }

                btnaddMon.Enabled = true;
            }
            SplashScreenManager.CloseForm();
        }

        private void imgListFood_Click(object sender, EventArgs e)
        {
            numQuantity.Value = 1;
            var a = imgListFood.SelectedItem.ToString();
            lbltenmon.Text = a;
            var objFPrice = new DataTable();
            objFPrice = fController.GetPriceByFName(a);
            txtPrice.Text = objFPrice.Rows[0]["FPrice"].ToString();
            if (objSale.Rows.Count > 0) srchCustomer.Enabled = false;
            else
            {
                srchCustomer.Enabled = true;
            }
        }

        private void lookEvent_TabIndexChanged(object sender, EventArgs e)
        {
            rtbRunevt.Text =
                ((DataRowView) lookEvent.Properties.GetDataSourceRowByKeyValue(lookEvent.EditValue))["Descript"]
                    .ToString();
        }

        private void LoadKH()
        {
            DataTable objTable;
            objTable = cusController.GetALL();
            srchCustomer.Properties.DataSource = objTable;
            srchCustomer.Properties.DisplayMember = "CusName";
            srchCustomer.Properties.ValueMember = "CusID";
            srchCustomer.EditValue = "62dc097d-a17b-46b0-8f96-53756f9033d9";
        }

        private void btnaddMon_CheckedChanged(object sender, EventArgs e)
        {
            if (lbltenmon.Text == "")
                XtraMessageBox.Show("Chưa chọn món", "Thông báo");
            else
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof (frmwait));
                    var ZoneCost = decimal.Parse(slController.GetZoneCOST(maban).Rows[0]["ZoneCost"].ToString());
                    int discount, temp;
                    var d =
                        ((DataRowView) lookEvent.Properties.GetDataSourceRowByKeyValue(lookEvent.EditValue))["EventID"]
                            .ToString();

                    CusID = Guid.Parse(srchCustomer.EditValue.ToString());
                    var objTable2 = new DataTable();
                    objTable2 = slController.GetDiscount(CusID, Guid.Parse(d));
                    if (rtbRunevt.Text == null) temp = 0;
                    else temp = int.Parse(objTable2.Rows[0]["Chiết Khấu"].ToString());
                    if (temp > 100) discount = 100;
                    else
                    {
                        discount = temp;
                    }
                    var price = Convert.ToInt32(txtPrice.Text);
                    var sl = numQuantity.Value;
                    var tenmon = objFgTable.Rows[imgListFood.SelectedIndex]["FoodName"].ToString();
                    if (objSale.Rows.Count > 0)
                        foreach (DataRow dtrow in objSale.Rows)
                        {
                            if (string.Compare(dtrow["FoodName"].ToString(), tenmon) == 0)
                            {
                                dtrow["Quantity"] = (Decimal) dtrow["Quantity"] + sl;
                                sl = Decimal.Parse(dtrow["Quantity"].ToString());
                                var dtttt = (Decimal) dtrow["Quantity"]*price;
                                ZoneCost = (dtttt*ZoneCost)/100;
                                dtrow["Price"] = ZoneCost + (dtttt - (dtttt*discount)/100);
                                lbltenmon.Text = "";
                            }
                        }
                    if (lbltenmon.Text != "")
                    {
                        var row = objSale.NewRow();
                        row["FoodName"] = lbltenmon.Text;
                        row["Quantity"] = sl;
                        row["FPrice"] = price;
                        row["ZoneCost"] = ZoneCost;
                        row["TotalDiscount"] = discount;
                        ZoneCost = ((sl*price)*ZoneCost)/100;
                        row["Price"] = ZoneCost + (sl*price) - ((sl*price*discount)/100);
                        row["Bill_ID"] = BILLID;
                        row["Value"] = sl*price;
                        objSale.Rows.Add(row);
                    }
                    var s = Tongtien();
                    var t = Thanhtoan();
                    lblMoney.Text = string.Format(CultureInfo.CreateSpecificCulture("vi-VN"), "{0:#,## VNĐ}", t);
                    if (gridCDaban.DataSource == null)
                    {
                        AddBill(discount, t, BILLID, s);
                        Add_BillDetail(BILLID, ZoneCost + (sl*price) - (sl*price*discount)/100, sl);
                    }
                    else
                    {
                        UpdateBill(s, t, (Guid) objSale.Rows[0]["Bill_ID"]);
                        for (var i = 0; i < objSale.Rows.Count; i++)
                        {
                            if (String.Compare(objSale.Rows[i]["FoodName"].ToString(), tenmon) == 0)
                            {
                                slController.BillDetail_Delete(objSale.Rows[0]["Bill_ID"].ToString(),
                                    objFgTable.Rows[imgListFood.SelectedIndex]["FoodID"].ToString());
                                Add_BillDetail((Guid) objSale.Rows[0]["Bill_ID"],
                                    ZoneCost + (sl*price) - (sl*price*discount)/100, sl);
                                break;
                            }
                            else
                            {
                                Add_BillDetail((Guid) objSale.Rows[0]["Bill_ID"],
                                    ZoneCost + (sl*price) - (sl*price*discount)/100, sl);
                            }
                        }
                    }
                    gridCDaban.DataSource = objSale;
                    indextabpage1 = tabZone1.SelectedTabPageIndex;
                    indextabpage2 = tabZone2.SelectedTabPageIndex;
                    FillViewImage();
                    tabZone1.SelectedTabPageIndex = indextabpage1;
                    tabZone2.SelectedTabPageIndex = indextabpage2;
                    btnInPhieu.Enabled = true;
                    SplashScreenManager.CloseForm();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    SplashScreenManager.CloseForm();
                }
            }
        }

        private decimal Tongtien()
        {
            Decimal s = 0;
            if (objSale.Rows.Count > 0)
            {
                for (var i = 0; i < objSale.Rows.Count; i++)
                {
                    s += (decimal) objSale.Rows[i]["Value"];
                }
            }
            else
            {
                s = 0;
            }
            return s;
        }

        private decimal Thanhtoan()
        {
            decimal s = 0;
            if (objSale.Rows.Count > 0)
            {
                for (var i = 0; i < objSale.Rows.Count; i++)
                {
                    s += (decimal) objSale.Rows[i]["Price"];
                }
            }
            else
            {
                s = 0;
            }
            return s;
        }

        private void UpdateBill(decimal value, decimal afDisc, Guid BillID)
        {
            var dt = new iCafeDataEn.iCafe_BillDataTable();
            var row = dt.NewiCafe_BillRow();
            row.Bill_ID = BillID;
            row.Value = value;
            row.AfterDiscount = afDisc;
            dt.Rows.Add(row);
            slController.Update_BillPrice(dt);
        }

        private void srchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != "") btnaddMon.Enabled = true;
            objSale.Rows.Clear();
            lblMoney.ResetText();
            BILLID = Guid.NewGuid();
        }

        private void btnApgia_Click(object sender, EventArgs e)
        {
            if (txtPrice.Enabled == false)
            {
                txtPrice.Enabled = true;
                btnApgia.Text = "Đặt giá";
            }
            else
            {
                txtPrice.Enabled = false;
                btnApgia.Text = "Áp giá";
            }
        }

        private void AddBill(int totalDisc, decimal afDisc, Guid billID, decimal value)
        {
            var dt = new iCafeDataEn.iCafe_BillDataTable();
            var rowBill = dt.NewiCafe_BillRow();
            rowBill.Bill_ID = billID;
            rowBill.TableID = maban;
            rowBill.EventID =
                (Guid) ((DataRowView) lookEvent.Properties.GetDataSourceRowByKeyValue(lookEvent.EditValue))["EventID"];
            rowBill.CusID = CusID;
            rowBill.EmployID = m_objSecurity._id;
            rowBill.BTableID = Guid.Empty;
            rowBill.Value = value;
            rowBill.TotalDiscount = totalDisc;
            rowBill.AfterDiscount = afDisc;
            rowBill.BTime = DateTime.Now;
            rowBill.BStatus = 5;
            dt.Rows.Add(rowBill);
            slController.Bill_ADD(dt);
        }

        private void Add_BillDetail(Guid billID, decimal price, decimal quantity)
        {
            var dt = new iCafeDataEn.iCafe_BillDetailDataTable();
            var rowBillDetail = dt.NewiCafe_BillDetailRow();
            rowBillDetail.Bill_ID = billID;
            rowBillDetail.FoodID = (Guid) objFgTable.Rows[imgListFood.SelectedIndex]["FoodID"];
            rowBillDetail.Quantity = quantity;
            rowBillDetail.Price = price;
            dt.Rows.Add(rowBillDetail);
            slController.BillDetail_ADD(dt);
        }

        private void Delete_BillDetail(Guid billID)
        {
        }

        private void listFGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgListFood.Enabled = true;
        }

        private void btnInPhieu_Click_1(object sender, EventArgs e)
        {
            var dr = XtraMessageBox.Show("Bạn có muốn in phiếu?", "Thông báo: ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if ((dr == DialogResult.Yes) && (objSale.Rows.Count > 0))
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                UpdateStatusBILL((Guid) objSale.Rows[0]["Bill_ID"], 2);
                indextabpage1 = tabZone1.SelectedTabPageIndex;
                indextabpage2 = tabZone2.SelectedTabPageIndex;
                FillViewImage();
                tabZone1.SelectedTabPageIndex = indextabpage1;
                tabZone2.SelectedTabPageIndex = indextabpage2;
                objSale.Rows.Clear();
                lblMoney.ResetText();
                SplashScreenManager.CloseForm();
            }
            else
            {
                XtraMessageBox.Show("Chưa có hóa đơn cho bàn này. \nKhông thể in!");
            }
            btnInPhieu.Enabled = false;
            btnThutien.Enabled = true;
        }

        private void UpdateStatusBILL(Guid bill_id, byte bstatus)
        {
            var dt = new iCafeDataEn.iCafe_BillDataTable();
            var row = dt.NewiCafe_BillRow();
            row.Bill_ID = bill_id;
            row.BStatus = bstatus;
            dt.Rows.Add(row);
            slController.UpdateStatusBill(dt);
        }

        private void btnThutien_Click(object sender, EventArgs e)
        {
            if (objSale.Rows.Count > 0)
            {
                SplashScreenManager.ShowForm(typeof (frmwait));
                UpdateStatusBILL((Guid) objSale.Rows[0]["Bill_ID"], 1);
                indextabpage1 = tabZone1.SelectedTabPageIndex;
                indextabpage2 = tabZone2.SelectedTabPageIndex;
                FillViewImage();
                tabZone1.SelectedTabPageIndex = indextabpage1;
                tabZone2.SelectedTabPageIndex = indextabpage2;
                objSale.Rows.Clear();
                lblMoney.ResetText();
                SplashScreenManager.CloseForm();
            }
            else
            {
                XtraMessageBox.Show("Chưa có hóa đơn cho bàn này. \nKhông thể thanh toán!");
            }
            btnThutien.Enabled = false;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            var frmBill = new frmBillEdit(objSale.Rows[0], m_objSQLConn, m_objSecurity);
            frmBill.ShowDialog();
        }
    }
}