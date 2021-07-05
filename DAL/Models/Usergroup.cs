using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Usergroup
    {
        public Usergroup()
        {
            Progprivileges = new HashSet<Progprivilege>();
            Users = new HashSet<User>();
        }

        public decimal UsergroupId { get; set; }
        public string Groupcode { get; set; }
        public string Groupname { get; set; }
        public string Note { get; set; }
        public decimal? Privilegeid { get; set; }
        public decimal? Pojectno { get; set; }
        public string Groupename { get; set; }
        public decimal? Active { get; set; }

        public virtual ICollection<Progprivilege> Progprivileges { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
