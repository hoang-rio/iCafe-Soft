namespace iCafe.Userform
{
    partial class frmSalary
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
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSalaryOverTime = new DevExpress.XtraEditors.TextEdit();
            this.txtSalaryValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookPer = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalaryOverTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalaryValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(385, 41);
            this.ucUpdate1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.txtSalaryOverTime);
            this.groupControl1.Controls.Add(this.txtSalaryValue);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lookPer);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(385, 220);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Cập nhật lương theo chức vụ";
            // 
            // txtSalaryOverTime
            // 
            this.txtSalaryOverTime.Location = new System.Drawing.Point(115, 144);
            this.txtSalaryOverTime.Name = "txtSalaryOverTime";
            this.txtSalaryOverTime.Size = new System.Drawing.Size(183, 20);
            this.txtSalaryOverTime.TabIndex = 2;
            // 
            // txtSalaryValue
            // 
            this.txtSalaryValue.Location = new System.Drawing.Point(115, 91);
            this.txtSalaryValue.Name = "txtSalaryValue";
            this.txtSalaryValue.Size = new System.Drawing.Size(183, 20);
            this.txtSalaryValue.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(310, 147);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "VNĐ/Giờ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mức lương ngoài giờ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(310, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "VNĐ/Tháng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mức lương";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chức vụ";
            // 
            // lookPer
            // 
            this.lookPer.Location = new System.Drawing.Point(115, 37);
            this.lookPer.Name = "lookPer";
            this.lookPer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookPer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PerName", "Tên chức vụ")});
            this.lookPer.Properties.NullText = "Chọn chức vụ";
            this.lookPer.Size = new System.Drawing.Size(183, 20);
            this.lookPer.TabIndex = 0;
            this.lookPer.EditValueChanged += new System.EventHandler(this.lookPer_EditValueChanged);
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 261);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmSalary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalaryOverTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalaryValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookPer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.ucUpdate ucUpdate1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSalaryOverTime;
        private DevExpress.XtraEditors.TextEdit txtSalaryValue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookPer;
    }
}