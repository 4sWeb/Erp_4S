using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityUser
    {
        public SecurityUser()
        {
            SecurityUserPrivileges = new HashSet<SecurityUserPrivilege>();
        }

        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal? Defaultlocale { get; set; }
        public decimal? Defaultapplication { get; set; }
        public bool? Isactive { get; set; }
        public int? ActiveStore { get; set; }

        public virtual ICollection<SecurityUserPrivilege> SecurityUserPrivileges { get; set; }
    }
}
