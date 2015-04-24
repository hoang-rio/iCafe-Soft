using System;

namespace iCafeLIB.Controller.Security
{
    public class SecurityContext
    {
        public string _UserName { get; set; }
        public string _Password { get; set; }
        public string _FullName { get; set; }
        public bool _LoginSuccess { get; set; }
        public bool _FullPermiss { get; set; }
        public bool _fc_warehouse { get; set; }
        public bool _fc_Customer { get; set; }
        public bool _fc_table { get; set; }
        public bool _fc_system { get; set; }
        public bool _fc_sale { get; set; }
        public bool _fc_revenue { get; set; }
        public bool _fc_event { get; set; }
        public Guid _id { set; get; }
    }
}