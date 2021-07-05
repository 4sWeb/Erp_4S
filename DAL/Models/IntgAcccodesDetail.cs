using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class IntgAcccodesDetail
    {
        public int Id { get; set; }
        public int IntgAcccodesMainId { get; set; }
        public int OrgType { get; set; }
        public int OrgForm { get; set; }
        public decimal? AccountId { get; set; }
        public decimal? Storeitem { get; set; }
        public string Acccode { get; set; }
        public string Compcode { get; set; }
        public decimal? OrgCode { get; set; }

        public virtual GlAccount Account { get; set; }
        public virtual IntgAcccodesMain IntgAcccodesMain { get; set; }
        public virtual StoreAllcode OrgCodeNavigation { get; set; }
        public virtual StoreItem StoreitemNavigation { get; set; }
    }
}
