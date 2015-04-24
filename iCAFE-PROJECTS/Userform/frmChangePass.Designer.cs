using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace iCafe.Userform
{
    partial class frmChangePass
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
            this.txtoldpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnewpw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtretypepw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangepw = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtoldpw
            // 
            this.txtoldpw.Location = new System.Drawing.Point(85, 10);
            this.txtoldpw.Name = "txtoldpw";
            this.txtoldpw.Size = new System.Drawing.Size(208, 21);
            this.txtoldpw.TabIndex = 0;
            this.txtoldpw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtnewpw
            // 
            this.txtnewpw.Location = new System.Drawing.Point(85, 37);
            this.txtnewpw.Name = "txtnewpw";
            this.txtnewpw.Size = new System.Drawing.Size(208, 21);
            this.txtnewpw.TabIndex = 1;
            this.txtnewpw.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtretypepw
            // 
            this.txtretypepw.Location = new System.Drawing.Point(85, 64);
            this.txtretypepw.Name = "txtretypepw";
            this.txtretypepw.Size = new System.Drawing.Size(208, 21);
            this.txtretypepw.TabIndex = 2;
            this.txtretypepw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập lại";
            // 
            // btnChangepw
            // 
            this.btnChangepw.Image = global::iCafe.Properties.Resources.save;
            this.btnChangepw.Location = new System.Drawing.Point(59, 91);
            this.btnChangepw.Name = "btnChangepw";
            this.btnChangepw.Size = new System.Drawing.Size(91, 45);
            this.btnChangepw.TabIndex = 3;
            this.btnChangepw.Text = "Đổi mật khẩu";
            this.btnChangepw.Click += new System.EventHandler(this.btnChangepw_Click);
            // 
            // btndong
            // 
            this.btndong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btndong.Image = global::iCafe.Properties.Resources.logout;
            this.btndong.Location = new System.Drawing.Point(169, 91);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(97, 45);
            this.btndong.TabIndex = 4;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // frmChangePass
            // 
            this.AcceptButton = this.btnChangepw;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btndong;
            this.ClientSize = new System.Drawing.Size(307, 143);
            this.ControlBox = false;
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnChangepw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtretypepw);
            this.Controls.Add(this.txtnewpw);
            this.Controls.Add(this.txtoldpw);
            this.Name = "frmChangePass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtoldpw;
        private Label label1;
        private TextBox txtnewpw;
        private Label label2;
        private TextBox txtretypepw;
        private Label label3;
        private SimpleButton btnChangepw;
        private SimpleButton btndong;
    }
}