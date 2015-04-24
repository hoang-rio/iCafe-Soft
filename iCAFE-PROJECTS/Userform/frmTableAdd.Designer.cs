using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iCafe.BaseControls;

namespace iCafe.Userform
{
    partial class frmTableAdd
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
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new DevExpress.XtraEditors.TextEdit();
            this.lookZone = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookZone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(339, 41);
            this.ucUpdate1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.lookZone);
            this.groupControl1.Controls.Add(this.txtTableName);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(339, 154);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Cập nhật thông tin bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bàn";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(98, 35);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Properties.NullText = "Nhập tên bàn";
            this.txtTableName.Size = new System.Drawing.Size(212, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // lookZone
            // 
            this.lookZone.Location = new System.Drawing.Point(98, 87);
            this.lookZone.Name = "lookZone";
            this.lookZone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookZone.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ZoneName", "Tên khu vực")});
            this.lookZone.Properties.NullText = "Chọn khu vực";
            this.lookZone.Size = new System.Drawing.Size(212, 20);
            this.lookZone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bàn";
            // 
            // frmTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 195);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmTableAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookZone.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucUpdate ucUpdate1;
        private GroupControl groupControl1;
        private LookUpEdit lookZone;
        private TextEdit txtTableName;
        private Label label2;
        private Label label1;
    }
}