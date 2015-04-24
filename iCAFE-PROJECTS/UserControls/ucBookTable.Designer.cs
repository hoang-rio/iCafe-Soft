using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using iCafe.BaseControl;

namespace iCafe.UserControls
{
    partial class ucBookTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bàn số 1",
            "111",
            "222",
            "333"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Bàn số 2", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Bàn số 3", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Bàn số 4", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Bàn số 5", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Bàn số 6", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Bàn số 7", "Wooden-Table-32.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBookTable));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("001", "Table-cloth.png");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("002", "Table-cloth.png");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("003", 4);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("004", 4);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("005", 4);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("006", 4);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("007", 4);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("001", 3);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("002", 3);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("003", 3);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("004", 3);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("005", 3);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("006", 3);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("007", 3);
            this.groupTableDetail = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridBookTable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ZoneName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Deposit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumPeople = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucBaseController2 = new iCafe.BaseControl.ucBaseController();
            this.groupViewTable = new DevExpress.XtraEditors.GroupControl();
            this.tabTable1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabSantruoc = new DevExpress.XtraTab.XtraTabPage();
            this.listTable = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList();
            this.tabSansau = new DevExpress.XtraTab.XtraTabPage();
            this.tabLau = new DevExpress.XtraTab.XtraTabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ucSimpleControl1 = new iCafe.BaseControls.ucSimpleControl();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.groupTableDetail)).BeginInit();
            this.groupTableDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupViewTable)).BeginInit();
            this.groupViewTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTable1)).BeginInit();
            this.tabTable1.SuspendLayout();
            this.tabSantruoc.SuspendLayout();
            this.tabLau.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTableDetail
            // 
            this.groupTableDetail.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupTableDetail.AppearanceCaption.Options.UseFont = true;
            this.groupTableDetail.Controls.Add(this.gridControl1);
            this.groupTableDetail.Controls.Add(this.ucBaseController2);
            this.groupTableDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupTableDetail.Location = new System.Drawing.Point(431, 0);
            this.groupTableDetail.Name = "groupTableDetail";
            this.groupTableDetail.Size = new System.Drawing.Size(667, 556);
            this.groupTableDetail.TabIndex = 3;
            this.groupTableDetail.Text = "Chi tiết đặt bàn";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 74);
            this.gridControl1.MainView = this.gridBookTable;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(663, 480);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBookTable});
            // 
            // gridBookTable
            // 
            this.gridBookTable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ZoneName,
            this.BookTime,
            this.EndTime,
            this.CusName,
            this.TableName,
            this.Deposit,
            this.NumPeople,
            this.CusPhone});
            this.gridBookTable.GridControl = this.gridControl1;
            this.gridBookTable.Name = "gridBookTable";
            this.gridBookTable.OptionsView.ShowGroupPanel = false;
            // 
            // ZoneName
            // 
            this.ZoneName.AppearanceCell.Options.UseTextOptions = true;
            this.ZoneName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneName.AppearanceHeader.Options.UseTextOptions = true;
            this.ZoneName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZoneName.Caption = "Khu vực";
            this.ZoneName.FieldName = "ZoneName";
            this.ZoneName.Name = "ZoneName";
            this.ZoneName.Visible = true;
            this.ZoneName.VisibleIndex = 2;
            // 
            // BookTime
            // 
            this.BookTime.AppearanceCell.Options.UseTextOptions = true;
            this.BookTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BookTime.AppearanceHeader.Options.UseTextOptions = true;
            this.BookTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BookTime.Caption = "Thời gian đặt";
            this.BookTime.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.BookTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.BookTime.FieldName = "BookTime";
            this.BookTime.Name = "BookTime";
            this.BookTime.Visible = true;
            this.BookTime.VisibleIndex = 4;
            // 
            // EndTime
            // 
            this.EndTime.AppearanceCell.Options.UseTextOptions = true;
            this.EndTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EndTime.AppearanceHeader.Options.UseTextOptions = true;
            this.EndTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EndTime.Caption = "Thời gian kết thúc";
            this.EndTime.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.EndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.EndTime.FieldName = "EndTime";
            this.EndTime.Name = "EndTime";
            this.EndTime.Visible = true;
            this.EndTime.VisibleIndex = 5;
            // 
            // CusName
            // 
            this.CusName.AppearanceCell.Options.UseTextOptions = true;
            this.CusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusName.AppearanceHeader.Options.UseTextOptions = true;
            this.CusName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusName.Caption = "Tên Khách hàng";
            this.CusName.FieldName = "CusName";
            this.CusName.MinWidth = 30;
            this.CusName.Name = "CusName";
            this.CusName.Visible = true;
            this.CusName.VisibleIndex = 0;
            // 
            // TableName
            // 
            this.TableName.AppearanceCell.Options.UseTextOptions = true;
            this.TableName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TableName.Caption = "Tên Bàn";
            this.TableName.FieldName = "TableName";
            this.TableName.Name = "TableName";
            this.TableName.Visible = true;
            this.TableName.VisibleIndex = 3;
            // 
            // Deposit
            // 
            this.Deposit.AppearanceCell.Options.UseTextOptions = true;
            this.Deposit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Deposit.AppearanceHeader.Options.UseTextOptions = true;
            this.Deposit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Deposit.Caption = "Đặt trước";
            this.Deposit.FieldName = "Deposit";
            this.Deposit.Name = "Deposit";
            this.Deposit.Visible = true;
            this.Deposit.VisibleIndex = 7;
            // 
            // NumPeople
            // 
            this.NumPeople.AppearanceCell.Options.UseTextOptions = true;
            this.NumPeople.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NumPeople.AppearanceHeader.Options.UseTextOptions = true;
            this.NumPeople.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NumPeople.Caption = "Số người";
            this.NumPeople.FieldName = "NumPeople";
            this.NumPeople.Name = "NumPeople";
            this.NumPeople.Visible = true;
            this.NumPeople.VisibleIndex = 6;
            // 
            // CusPhone
            // 
            this.CusPhone.AppearanceCell.Options.UseTextOptions = true;
            this.CusPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.CusPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CusPhone.Caption = "Số điện thoại";
            this.CusPhone.FieldName = "CusPhone";
            this.CusPhone.Name = "CusPhone";
            this.CusPhone.Visible = true;
            this.CusPhone.VisibleIndex = 1;
            // 
            // ucBaseController2
            // 
            this.ucBaseController2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController2.Location = new System.Drawing.Point(2, 24);
            this.ucBaseController2.Name = "ucBaseController2";
            this.ucBaseController2.Size = new System.Drawing.Size(663, 50);
            this.ucBaseController2.TabIndex = 2;
            // 
            // groupViewTable
            // 
            this.groupViewTable.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupViewTable.AppearanceCaption.Options.UseFont = true;
            this.groupViewTable.Controls.Add(this.tabTable1);
            this.groupViewTable.Controls.Add(this.ucSimpleControl1);
            this.groupViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupViewTable.Location = new System.Drawing.Point(0, 0);
            this.groupViewTable.Name = "groupViewTable";
            this.groupViewTable.Size = new System.Drawing.Size(431, 556);
            this.groupViewTable.TabIndex = 4;
            this.groupViewTable.Text = "Bàn và Khu vực";
            // 
            // tabTable1
            // 
            this.tabTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTable1.Location = new System.Drawing.Point(2, 66);
            this.tabTable1.Name = "tabTable1";
            this.tabTable1.SelectedTabPage = this.tabSantruoc;
            this.tabTable1.Size = new System.Drawing.Size(427, 488);
            this.tabTable1.TabIndex = 2;
            this.tabTable1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabSantruoc,
            this.tabSansau,
            this.tabLau});
            this.tabTable1.Click += new System.EventHandler(this.tabTable1_Click);
            // 
            // tabSantruoc
            // 
            this.tabSantruoc.Controls.Add(this.listTable);
            this.tabSantruoc.Name = "tabSantruoc";
            this.tabSantruoc.Size = new System.Drawing.Size(421, 460);
            this.tabSantruoc.Text = "Sân trước";
            // 
            // listTable
            // 
            this.listTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTable.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listTable.LargeImageList = this.imgList;
            this.listTable.Location = new System.Drawing.Point(0, 0);
            this.listTable.Name = "listTable";
            this.listTable.Size = new System.Drawing.Size(421, 460);
            this.listTable.SmallImageList = this.imgList;
            this.listTable.TabIndex = 0;
            this.listTable.UseCompatibleStateImageBehavior = false;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Wooden-Table-32.png");
            this.imgList.Images.SetKeyName(1, "White-Sofa-32.png");
            this.imgList.Images.SetKeyName(2, "Bar-stool-32.png");
            this.imgList.Images.SetKeyName(3, "table-icon-med.png");
            this.imgList.Images.SetKeyName(4, "Table-cloth.png");
            // 
            // tabSansau
            // 
            this.tabSansau.Name = "tabSansau";
            this.tabSansau.Size = new System.Drawing.Size(421, 460);
            this.tabSansau.Text = "Sân sau";
            // 
            // tabLau
            // 
            this.tabLau.Controls.Add(this.listView2);
            this.tabLau.Name = "tabLau";
            this.tabLau.Size = new System.Drawing.Size(421, 460);
            this.tabLau.Text = "Trên lầu";
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.listView2.LargeImageList = this.imgList;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(421, 460);
            this.listView2.SmallImageList = this.imgList;
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // ucSimpleControl1
            // 
            this.ucSimpleControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSimpleControl1.Location = new System.Drawing.Point(2, 24);
            this.ucSimpleControl1.Name = "ucSimpleControl1";
            this.ucSimpleControl1.Size = new System.Drawing.Size(427, 42);
            this.ucSimpleControl1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21});
            this.listView1.LargeImageList = this.imgList;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(472, 192);
            this.listView1.SmallImageList = this.imgList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ucBookTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupViewTable);
            this.Controls.Add(this.groupTableDetail);
            this.Name = "ucBookTable";
            this.Size = new System.Drawing.Size(1098, 556);
            this.Load += new System.EventHandler(this.ucBookTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupTableDetail)).EndInit();
            this.groupTableDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupViewTable)).EndInit();
            this.groupViewTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabTable1)).EndInit();
            this.tabTable1.ResumeLayout(false);
            this.tabSantruoc.ResumeLayout(false);
            this.tabLau.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupTableDetail;
        private GroupControl groupViewTable;
        private ListView listView1;
        private ImageList imgList;
        private GridControl gridControl1;
        private GridView gridBookTable;
        private ucBaseController ucBaseController2;
        private GridColumn ZoneName;
        private GridColumn BookTime;
        private GridColumn EndTime;
        private GridColumn CusName;
        private GridColumn Deposit;
        private GridColumn NumPeople;
        private GridColumn CusPhone;
        private GridColumn TableName;
        private XtraTabControl tabTable1;
        private XtraTabPage tabSantruoc;
        private ListView listTable;
        private XtraTabPage tabSansau;
        private XtraTabPage tabLau;
        private ListView listView2;
        private BaseControls.ucSimpleControl ucSimpleControl1;
    }
}
