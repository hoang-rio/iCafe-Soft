namespace iCafe.Userform
{
    partial class frmSearchBox
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
            this.lookWS = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCa = new DevExpress.XtraEditors.LabelControl();
            this.txtkeyWord = new DevExpress.XtraEditors.TextEdit();
            this.lblkeyword = new DevExpress.XtraEditors.LabelControl();
            this.ucUpdate1 = new iCafe.BaseControls.ucUpdate();
            ((System.ComponentModel.ISupportInitialize)(this.lookWS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkeyWord.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookWS
            // 
            this.lookWS.Location = new System.Drawing.Point(94, 61);
            this.lookWS.Name = "lookWS";
            this.lookWS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookWS.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WSName", "Tên ca")});
            this.lookWS.Properties.NullText = "Chọn ca";
            this.lookWS.Size = new System.Drawing.Size(205, 20);
            this.lookWS.TabIndex = 1;
            this.lookWS.Visible = false;
            // 
            // lblCa
            // 
            this.lblCa.Location = new System.Drawing.Point(22, 64);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(36, 13);
            this.lblCa.TabIndex = 2;
            this.lblCa.Text = "Ca trực";
            this.lblCa.Visible = false;
            // 
            // txtkeyWord
            // 
            this.txtkeyWord.Location = new System.Drawing.Point(94, 61);
            this.txtkeyWord.Name = "txtkeyWord";
            this.txtkeyWord.Size = new System.Drawing.Size(205, 20);
            this.txtkeyWord.TabIndex = 3;
            this.txtkeyWord.Visible = false;
            // 
            // lblkeyword
            // 
            this.lblkeyword.Location = new System.Drawing.Point(22, 64);
            this.lblkeyword.Name = "lblkeyword";
            this.lblkeyword.Size = new System.Drawing.Size(39, 13);
            this.lblkeyword.TabIndex = 2;
            this.lblkeyword.Text = "Từ khóa";
            this.lblkeyword.Visible = false;
            // 
            // ucUpdate1
            // 
            this.ucUpdate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUpdate1.Location = new System.Drawing.Point(0, 0);
            this.ucUpdate1.Name = "ucUpdate1";
            this.ucUpdate1.Size = new System.Drawing.Size(340, 41);
            this.ucUpdate1.TabIndex = 0;
            // 
            // frmSearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 108);
            this.ControlBox = false;
            this.Controls.Add(this.txtkeyWord);
            this.Controls.Add(this.lblkeyword);
            this.Controls.Add(this.lblCa);
            this.Controls.Add(this.lookWS);
            this.Controls.Add(this.ucUpdate1);
            this.Name = "frmSearchBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCafe - Project";
            ((System.ComponentModel.ISupportInitialize)(this.lookWS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkeyWord.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.ucUpdate ucUpdate1;
        private DevExpress.XtraEditors.LabelControl lblCa;
        public DevExpress.XtraEditors.LookUpEdit lookWS;
        public DevExpress.XtraEditors.TextEdit txtkeyWord;
        private DevExpress.XtraEditors.LabelControl lblkeyword;
    }
}