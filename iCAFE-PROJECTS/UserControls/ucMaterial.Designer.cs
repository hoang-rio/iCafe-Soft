using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;

namespace iCafe.UserControls
{
    partial class ucMaterial
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
            this.ucBaseController1 = new iCafe.BaseControls.ucBaseController();
            this.gridMaterial = new DevExpress.XtraGrid.GridControl();
            this.gridRawMaterial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RMName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descript = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RMPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRawMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(692, 50);
            this.ucBaseController1.TabIndex = 0;
            // 
            // gridMaterial
            // 
            this.gridMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMaterial.Location = new System.Drawing.Point(0, 50);
            this.gridMaterial.MainView = this.gridRawMaterial;
            this.gridMaterial.Name = "gridMaterial";
            this.gridMaterial.Size = new System.Drawing.Size(692, 367);
            this.gridMaterial.TabIndex = 1;
            this.gridMaterial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridRawMaterial});
            // 
            // gridRawMaterial
            // 
            this.gridRawMaterial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RMName,
            this.Quantity,
            this.Unit,
            this.Descript,
            this.RMPrice});
            this.gridRawMaterial.GridControl = this.gridMaterial;
            this.gridRawMaterial.Name = "gridRawMaterial";
            this.gridRawMaterial.OptionsView.ShowGroupPanel = false;
            // 
            // RMName
            // 
            this.RMName.AppearanceCell.Options.UseTextOptions = true;
            this.RMName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RMName.AppearanceHeader.Options.UseTextOptions = true;
            this.RMName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RMName.Caption = "Tên nguyên liệu";
            this.RMName.FieldName = "RMName";
            this.RMName.Name = "RMName";
            this.RMName.Visible = true;
            this.RMName.VisibleIndex = 0;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Options.UseTextOptions = true;
            this.Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.Caption = "Số lượng";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 1;
            // 
            // Unit
            // 
            this.Unit.AppearanceCell.Options.UseTextOptions = true;
            this.Unit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Unit.AppearanceHeader.Options.UseTextOptions = true;
            this.Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Unit.Caption = "Đơn vị";
            this.Unit.FieldName = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Visible = true;
            this.Unit.VisibleIndex = 2;
            // 
            // Descript
            // 
            this.Descript.AppearanceCell.Options.UseTextOptions = true;
            this.Descript.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descript.AppearanceHeader.Options.UseTextOptions = true;
            this.Descript.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descript.Caption = "Mô tả";
            this.Descript.FieldName = "Descript";
            this.Descript.Name = "Descript";
            this.Descript.Visible = true;
            this.Descript.VisibleIndex = 3;
            // 
            // RMPrice
            // 
            this.RMPrice.AppearanceCell.Options.UseTextOptions = true;
            this.RMPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RMPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RMPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.RMPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RMPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RMPrice.Caption = "Giá";
            this.RMPrice.FieldName = "RMPrice";
            this.RMPrice.Name = "RMPrice";
            this.RMPrice.Visible = true;
            this.RMPrice.VisibleIndex = 4;
            // 
            // ucMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridMaterial);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucMaterial";
            this.Size = new System.Drawing.Size(692, 417);
            this.Load += new System.EventHandler(this.ucMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRawMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBaseController ucBaseController1;
        private GridControl gridMaterial;
        private GridView gridRawMaterial;
        private GridColumn RMName;
        private GridColumn Quantity;
        private GridColumn Unit;
        private GridColumn Descript;
        private GridColumn RMPrice;
    }
}
