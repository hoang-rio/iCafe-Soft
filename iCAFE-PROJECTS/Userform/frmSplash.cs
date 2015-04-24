using System;
using DevExpress.XtraSplashScreen;

namespace iCafe
{
    public partial class frmSplash : SplashScreen
    {
        public enum SplashScreenCommand
        {
        }

        public frmSplash()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}