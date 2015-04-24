namespace iCafe.UserControls
{
    partial class ucSalesMain
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
            DevExpress.XtraEditors.SimpleButton btnTable;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSalesMain));
            DevExpress.XtraEditors.SimpleButton btnFood;
            DevExpress.XtraEditors.SimpleButton btnSale;
            DevExpress.XtraEditors.SimpleButton btnZoneTable;
            DevExpress.XtraEditors.SimpleButton btnMaterialFood;
            DevExpress.XtraEditors.SimpleButton btnCustomer;
            btnTable = new DevExpress.XtraEditors.SimpleButton();
            btnFood = new DevExpress.XtraEditors.SimpleButton();
            btnSale = new DevExpress.XtraEditors.SimpleButton();
            btnZoneTable = new DevExpress.XtraEditors.SimpleButton();
            btnMaterialFood = new DevExpress.XtraEditors.SimpleButton();
            btnCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnTable
            // 
            resources.ApplyResources(btnTable, "btnTable");
            btnTable.BackgroundImage = global::iCafe.Properties.Resources.clock;
            btnTable.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTable.Image = global::iCafe.Properties.Resources.clock;
            btnTable.Name = "btnTable";
            btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnFood
            // 
            resources.ApplyResources(btnFood, "btnFood");
            btnFood.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            btnFood.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFood.Image = global::iCafe.Properties.Resources.x_office_address_book1;
            btnFood.Name = "btnFood";
            btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnSale
            // 
            resources.ApplyResources(btnSale, "btnSale");
            btnSale.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSale.Image = global::iCafe.Properties.Resources.Cash_register_icon;
            btnSale.Name = "btnSale";
            btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnZoneTable
            // 
            btnZoneTable.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            btnZoneTable.Cursor = System.Windows.Forms.Cursors.Hand;
            btnZoneTable.Image = global::iCafe.Properties.Resources.White_Sofa_32;
            resources.ApplyResources(btnZoneTable, "btnZoneTable");
            btnZoneTable.Name = "btnZoneTable";
            btnZoneTable.Click += new System.EventHandler(this.btnZoneTable_Click);
            // 
            // btnMaterialFood
            // 
            btnMaterialFood.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            btnMaterialFood.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMaterialFood.Image = global::iCafe.Properties.Resources.Crate_Download;
            resources.ApplyResources(btnMaterialFood, "btnMaterialFood");
            btnMaterialFood.Name = "btnMaterialFood";
            btnMaterialFood.Click += new System.EventHandler(this.btnMaterialFood_Click);
            // 
            // btnCustomer
            // 
            btnCustomer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCustomer.Image = global::iCafe.Properties.Resources.personal_information48;
            resources.ApplyResources(btnCustomer, "btnCustomer");
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // ucSalesMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iCafe.Properties.Resources.iCafe;
            this.Controls.Add(btnCustomer);
            this.Controls.Add(btnMaterialFood);
            this.Controls.Add(btnZoneTable);
            this.Controls.Add(btnSale);
            this.Controls.Add(btnFood);
            this.Controls.Add(btnTable);
            this.Name = "ucSalesMain";
            this.ResumeLayout(false);

        }

        #endregion


        ////private Button button1;
        ////private Button button2;
        ////private Button button3;
    }
}
