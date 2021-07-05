using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityUserPrivilege
    {
        public decimal Id { get; set; }
        public decimal UserId { get; set; }
        public string AddBasic { get; set; }
        public string AddTrans { get; set; }
        public string UpdateBasic { get; set; }
        public string UpdateTrans { get; set; }
        public string DelBasic { get; set; }
        public string DelTrans { get; set; }
        public string EditTransNumber { get; set; }
        public string ViewMenuSpecs { get; set; }
        public string EditBranch { get; set; }
        public string SelectStoreDb { get; set; }
        public string EditContract { get; set; }

        public virtual SecurityUser User { get; set; }
    }
}
