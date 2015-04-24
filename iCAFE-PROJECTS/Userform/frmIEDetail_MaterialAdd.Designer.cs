namespace iCafe.Userform
{
    partial class frmIEDetail_MaterialAdd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picMaterial = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.spinQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateImportDate = new DevExpress.XtraEditors.DateEdit();
            this.dateExpireDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lookMaterial = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetailNote = new DevExpress.XtraEditors.MemoEdit();
            this.RMName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateImportDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateImportDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpireDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpireDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picMaterial
            // 
            this.picMaterial.Location = new System.Drawing.Point(322, 66);
            this.picMaterial.Name = "picMaterial";
            this.picMaterial.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picMaterial.Size = new System.Drawing.Size(125, 121);
            this.picMaterial.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày nhập";
            // 
            // spinQuantity
            // 
            this.spinQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinQuantity.Location = new System.Drawing.Point(79, 102);
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
            this.spinQuantity.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nguyên liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số lượng";
            // 
            // dateImportDate
            // 
            this.dateImportDate.EditValue = null;
            this.dateImportDate.Location = new System.Drawing.Point(79, 137);
            this.dateImportDate.Name = "dateImportDate";
            this.dateImportDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateImportDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateImportDate.Size = new System.Drawing.Size(222, 20);
            this.dateImportDate.TabIndex = 24;
            // 
            // dateExpireDate
            // 
            this.dateExpireDate.EditValue = null;
            this.dateExpireDate.Location = new System.Drawing.Point(79, 169);
            this.dateExpireDate.Name = "dateExpireDate";
            this.dateExpireDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateExpireDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateExpireDate.Size = new System.Drawing.Size(222, 20);
            this.dateExpireDate.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hết hạn";
            // 
            // lookMaterial
            // 
            this.lookMaterial.EditValue = "Hãy chọn nguyên liệu";
            this.lookMaterial.Location = new System.Drawing.Point(81, 67);
            this.lookMaterial.Name = "lookMaterial";
            this.lookMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookMaterial.Properties.NullText = "Chọn nguyên liệu";
            this.lookMaterial.Properties.View = this.searchLookUpEdit1View;
            this.lookMaterial.Size = new System.Drawing.Size(220, 20);
            this.lookMaterial.TabIndex = 29;
            this.lookMaterial.EditValueChanged += new System.EventHandler(this.lookMaterial_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RMName});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(460, 41);
            this.ucUpdate1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ghi chú";
            // 
            // txtDetailNote
            // 
            this.txtDetailNote.Location = new System.Drawing.Point(79, 204);
            this.txtDetailNote.Name = "txtDetailNote";
            this.txtDetailNote.Size = new System.Drawing.Size(222, 87);
            this.txtDetailNote.TabIndex = 28;
            // 
            // RMName
            // 
            this.RMName.Caption = "Tên nguyên liệu";
            this.RMName.FieldName = "RMName";
            this.RMName.Name = "RMName";
            this.RMName.Visible = true;
            this.RMName.VisibleIndex = 0;
            // 
            // frmIEDetail_MaterialAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 303);
            this.ControlBox = false;
            this.Controls.Add(this.lookMaterial);
            this.Controls.Add(this.txtDetailNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateExpireDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateImportDate);
            this.Controls.Add(this.picMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmIEDetail_MaterialAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.picMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateImportDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateImportDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpireDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpireDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailNote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.ucUpdate ucUpdate1;
        private DevExpress.XtraEditors.PictureEdit picMaterial;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SpinEdit spinQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateImportDate;
        private DevExpress.XtraEditors.DateEdit dateExpireDate;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SearchLookUpEdit lookMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit txtDetailNote;
        private DevExpress.XtraGrid.Columns.GridColumn RMName;

    }
}