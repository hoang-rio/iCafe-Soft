using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmBookTable_FoodAdd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.spinQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lookFood = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lookFGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.picFood = new DevExpress.XtraEditors.PictureEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.FoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Funit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFood.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên món";
            // 
            // spinQuantity
            // 
            this.spinQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinQuantity.Location = new System.Drawing.Point(70, 148);
            this.spinQuantity.Name = "spinQuantity";
            this.spinQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinQuantity.Properties.Mask.EditMask = "n0";
            this.spinQuantity.Properties.MaxLength = 3;
            this.spinQuantity.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinQuantity.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinQuantity.Size = new System.Drawing.Size(222, 20);
            this.spinQuantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng";
            // 
            // lookFood
            // 
            this.lookFood.Location = new System.Drawing.Point(70, 116);
            this.lookFood.Name = "lookFood";
            this.lookFood.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookFood.Properties.NullText = "Mời chọn món";
            this.lookFood.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemPictureEdit2});
            this.lookFood.Properties.View = this.searchLookUpEdit1View;
            this.lookFood.Size = new System.Drawing.Size(222, 20);
            this.lookFood.TabIndex = 5;
            this.lookFood.EditValueChanged += new System.EventHandler(this.lookFood_EditValueChanged_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FoodName,
            this.Funit,
            this.FPrice});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lookFGroup
            // 
            this.lookFGroup.Location = new System.Drawing.Point(70, 81);
            this.lookFGroup.Name = "lookFGroup";
            this.lookFGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookFGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FGrName", "Tên nhóm món")});
            this.lookFGroup.Properties.NullText = "Hãy chọn nhóm món";
            this.lookFGroup.Size = new System.Drawing.Size(222, 20);
            this.lookFGroup.TabIndex = 6;
            this.lookFGroup.EditValueChanged += new System.EventHandler(this.Food_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhóm món";
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(331, 47);
            this.picFood.Name = "picFood";
            this.picFood.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picFood.Size = new System.Drawing.Size(125, 121);
            this.picFood.TabIndex = 7;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // FoodName
            // 
            this.FoodName.Caption = "Tên món";
            this.FoodName.FieldName = "FoodName";
            this.FoodName.Name = "FoodName";
            this.FoodName.Visible = true;
            this.FoodName.VisibleIndex = 0;
            // 
            // Funit
            // 
            this.Funit.Caption = "Đơn vị tính";
            this.Funit.FieldName = "FUnit";
            this.Funit.Name = "Funit";
            this.Funit.Visible = true;
            this.Funit.VisibleIndex = 1;
            // 
            // FPrice
            // 
            this.FPrice.Caption = "Giá (VNĐ)";
            this.FPrice.FieldName = "FPrice";
            this.FPrice.Name = "FPrice";
            this.FPrice.Visible = true;
            this.FPrice.VisibleIndex = 2;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(481, 41);
            this.ucUpdate1.TabIndex = 2;
            // 
            // frmBookTable_FoodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(481, 191);
            this.ControlBox = false;
            this.Controls.Add(this.picFood);
            this.Controls.Add(this.lookFGroup);
            this.Controls.Add(this.lookFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinQuantity);
            this.Controls.Add(this.ucUpdate1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBookTable_FoodAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFood.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ucUpdate ucUpdate1;
        private SpinEdit spinQuantity;
        private Label label2;
        private SearchLookUpEdit lookFood;
        private GridView searchLookUpEdit1View;
        private GridColumn FoodName;
        private LookUpEdit lookFGroup;
        private Label label3;
        private RepositoryItemImageEdit repositoryItemImageEdit1;
        private RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private GridColumn Funit;
        private GridColumn FPrice;
        private PictureEdit picFood;
    }
}