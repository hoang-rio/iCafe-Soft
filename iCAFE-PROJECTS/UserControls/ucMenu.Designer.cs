using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControl;
using iCafe.BaseControls;

namespace iCafe.UserControls
{
    partial class ucMenu
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
            this.ucBaseController1 = new iCafe.BaseControl.ucBaseController();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridFood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.ucSimpleControl1 = new iCafe.BaseControls.ucSimpleControl();
            this.listFGroup = new DevExpress.XtraEditors.ImageListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBaseController1
            // 
            this.ucBaseController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBaseController1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseController1.Name = "ucBaseController1";
            this.ucBaseController1.Size = new System.Drawing.Size(839, 49);
            this.ucBaseController1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.listFGroup);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 49);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(839, 354);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Nhóm món";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Controls.Add(this.ucSimpleControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(242, 21);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(595, 331);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Món";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 63);
            this.gridControl2.MainView = this.gridFood;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gridControl2.Size = new System.Drawing.Size(591, 266);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFood});
            // 
            // gridFood
            // 
            this.gridFood.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FoodName,
            this.FUnit,
            this.FPrice,
            this.FImage});
            this.gridFood.GridControl = this.gridControl2;
            this.gridFood.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridFood.Name = "gridFood";
            this.gridFood.OptionsView.ShowGroupPanel = false;
            // 
            // FoodName
            // 
            this.FoodName.AppearanceCell.Options.UseTextOptions = true;
            this.FoodName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FoodName.AppearanceHeader.Options.UseTextOptions = true;
            this.FoodName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FoodName.Caption = "Tên món";
            this.FoodName.FieldName = "FoodName";
            this.FoodName.Name = "FoodName";
            this.FoodName.Visible = true;
            this.FoodName.VisibleIndex = 0;
            // 
            // FUnit
            // 
            this.FUnit.AppearanceCell.Options.UseTextOptions = true;
            this.FUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.FUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FUnit.Caption = "Đơn vị tính";
            this.FUnit.FieldName = "FUnit";
            this.FUnit.Name = "FUnit";
            this.FUnit.Visible = true;
            this.FUnit.VisibleIndex = 1;
            // 
            // FPrice
            // 
            this.FPrice.AppearanceCell.Options.UseTextOptions = true;
            this.FPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.FPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FPrice.Caption = "Giá";
            this.FPrice.FieldName = "FPrice";
            this.FPrice.Name = "FPrice";
            this.FPrice.Visible = true;
            this.FPrice.VisibleIndex = 2;
            // 
            // FImage
            // 
            this.FImage.AppearanceCell.Options.UseTextOptions = true;
            this.FImage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FImage.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FImage.AppearanceHeader.Options.UseTextOptions = true;
            this.FImage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FImage.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FImage.Caption = "Ảnh";
            this.FImage.ColumnEdit = this.repositoryItemImageEdit1;
            this.FImage.FieldName = "FImage";
            this.FImage.Name = "FImage";
            this.FImage.Visible = true;
            this.FImage.VisibleIndex = 3;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // ucSimpleControl1
            // 
            this.ucSimpleControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSimpleControl1.Location = new System.Drawing.Point(2, 21);
            this.ucSimpleControl1.Name = "ucSimpleControl1";
            this.ucSimpleControl1.Size = new System.Drawing.Size(591, 42);
            this.ucSimpleControl1.TabIndex = 5;
            // 
            // listFGroup
            // 
            this.listFGroup.Appearance.BackColor = System.Drawing.Color.White;
            this.listFGroup.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listFGroup.Appearance.Options.UseBackColor = true;
            this.listFGroup.Appearance.Options.UseFont = true;
            this.listFGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.listFGroup.Location = new System.Drawing.Point(2, 21);
            this.listFGroup.Name = "listFGroup";
            this.listFGroup.Size = new System.Drawing.Size(240, 331);
            this.listFGroup.TabIndex = 5;
            this.listFGroup.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.listFGroup_DrawItem);
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucBaseController1);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(839, 403);
            this.Load += new System.EventHandler(this.ucMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listFGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBaseController ucBaseController1;
        private GroupControl groupControl1;
        private ImageListBoxControl listFGroup;
        private GroupControl groupControl2;
        private GridControl gridControl2;
        private GridView gridFood;
        private GridColumn FoodName;
        private GridColumn FUnit;
        private GridColumn FPrice;
        private ucSimpleControl ucSimpleControl1;
        private GridColumn FImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
    }
}
