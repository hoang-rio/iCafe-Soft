using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace iCafe.BaseControl
{
    public partial class ucBaseController : XtraUserControl
    {
        public ucBaseController()
        {
            InitializeComponent();
        }

        public event EventHandler PressNew;
        public event EventHandler PressEdit;
        public event EventHandler PressRefresh;
        public event EventHandler PressDelete;
        public event EventHandler PressHelp;
        public event EventHandler PressClose;
        public event EventHandler PressSearch;
        public event EventHandler PressReport;

        private void btnThemMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PressNew != null)
                PressNew(sender, null);
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PressEdit != null)
                PressEdit(sender, null);
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PressDelete != null)
                PressDelete(sender, null);
        }

        private void btnNapLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PressRefresh != null)
                PressRefresh(sender, null);
        }

        private void btnTroGiup_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PressHelp != null)
                PressHelp(sender, null);
        }

        private void btnBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PressReport != null)
                PressReport(sender, null);
        }

        private void bBITimKiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PressSearch != null)
                PressSearch(sender, null);
        }

        private void btnDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PressClose != null)
                PressClose(sender, null);
        }

        public void Delete_Remove()
        {
            barManager1.Items.Remove(btnXoa);
        }
    }
}