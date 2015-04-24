using System;
using System.Configuration;
using System.Drawing;
using DevExpress.XtraEditors;

namespace iCafe.Userform
{
    public partial class frmFontEdit : XtraForm
    {
        public frmFontEdit()
        {
            InitializeComponent();
            ucUpdate1.btnFDong.ItemClick += Close_Click;
            ucUpdate1.btnFCapNhat.ItemClick += Update_Click;
            foreach (var font in FontFamily.Families)
            {
                cbbfont.Properties.Items.Add(font.Name);
            }
        }

        private void cbbfont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richPreview.Font = new Font(cbbfont.Text, cbbSize.SelectedIndex + 5);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            ConfigurationSettings.AppSettings.Set("font", cbbfont.SelectedItem.ToString());
            ConfigurationSettings.AppSettings.Set("fontsize", cbbSize.SelectedItem.ToString());
            XtraMessageBox.Show("Cập nhật thành công");
            Dispose();
        }
    }
}