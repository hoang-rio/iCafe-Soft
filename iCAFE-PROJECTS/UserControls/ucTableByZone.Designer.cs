namespace iCafe.UserControls
{
    partial class ucTableByZone
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bàn số 1",
            "111",
            "222",
            "333"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Bàn số 2", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Bàn số 3", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Bàn số 4", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Bàn số 5", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Bàn số 6", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Bàn số 7", "Wooden-Table-32.png");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("001", "Table-cloth.png");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("002", "Table-cloth.png");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("003");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("004");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("005");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("006");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("007");
            this.groupViewTable = new DevExpress.XtraEditors.GroupControl();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabTable1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabSantruoc = new DevExpress.XtraTab.XtraTabPage();
            this.listTable = new System.Windows.Forms.ListView();
            this.tabSansau = new DevExpress.XtraTab.XtraTabPage();
            this.tabLau = new DevExpress.XtraTab.XtraTabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.groupViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTable1)).BeginInit();
            this.tabTable1.SuspendLayout();
            this.tabSantruoc.SuspendLayout();
            this.tabLau.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupViewTable
            // 
            this.groupViewTable.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupViewTable.AppearanceCaption.Options.UseFont = true;
            this.groupViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupViewTable.Location = new System.Drawing.Point(0, 0);
            this.groupViewTable.Name = "groupViewTable";
            this.groupViewTable.Size = new System.Drawing.Size(745, 431);
            this.groupViewTable.TabIndex = 5;
            this.groupViewTable.Text = "Bàn và Khu vực";
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleButton1.Image = global::iCafe.Properties.Resources.cancel;
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(745, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Đóng";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabTable1
            // 
            this.tabTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTable1.Location = new System.Drawing.Point(0, 23);
            this.tabTable1.Name = "tabTable1";
            this.tabTable1.SelectedTabPage = this.tabSantruoc;
            this.tabTable1.Size = new System.Drawing.Size(745, 408);
            this.tabTable1.TabIndex = 7;
            this.tabTable1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabSantruoc,
            this.tabSansau,
            this.tabLau});
            // 
            // tabSantruoc
            // 
            this.tabSantruoc.Controls.Add(this.listTable);
            this.tabSantruoc.Name = "tabSantruoc";
            this.tabSantruoc.Size = new System.Drawing.Size(739, 380);
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
            this.listTable.Size = new System.Drawing.Size(739, 380);
            this.listTable.SmallImageList = this.imgList;
            this.listTable.TabIndex = 0;
            this.listTable.UseCompatibleStateImageBehavior = false;
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
            // ucTableByZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabTable1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupViewTable);
            this.Name = "ucTableByZone";
            this.Size = new System.Drawing.Size(745, 431);
            ((System.ComponentModel.ISupportInitialize)(this.groupViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTable1)).EndInit();
            this.tabTable1.ResumeLayout(false);
            this.tabSantruoc.ResumeLayout(false);
            this.tabLau.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupViewTable;
        private System.Windows.Forms.ImageList imgList;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabControl tabTable1;
        private DevExpress.XtraTab.XtraTabPage tabSantruoc;
        private System.Windows.Forms.ListView listTable;
        private DevExpress.XtraTab.XtraTabPage tabSansau;
        private DevExpress.XtraTab.XtraTabPage tabLau;
        private System.Windows.Forms.ListView listView2;
    }
}
