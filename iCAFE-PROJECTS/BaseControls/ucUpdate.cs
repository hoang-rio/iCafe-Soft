using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace iCafe.BaseControls
{
    public partial class ucUpdate : XtraUserControl
    {
        public ucUpdate()
        {
            InitializeComponent();
        }

        private void btnThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnFCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnFNapLai_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnFTroGiup_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnFDong_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        public void DeleteButton()
        {
            barUpdate.Items.Remove(btnFCapNhat);
            barUpdate.Items.Remove(btnFNapLai);
        }
    }
}