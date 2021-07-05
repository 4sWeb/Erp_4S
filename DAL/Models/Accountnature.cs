using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Accountnature
    {
        public Accountnature()
        {
            Accounts = new HashSet<Account>();
            Accountstrees = new HashSet<Accountstree>();
            Glintegratoros = new HashSet<Glintegratoro>();
            LgDescriptionsOs = new HashSet<LgDescriptionsO>();
        }

        public decimal Accountnatureid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Accountstree> Accountstrees { get; set; }
        public virtual ICollection<Glintegratoro> Glintegratoros { get; set; }
        public virtual ICollection<LgDescriptionsO> LgDescriptionsOs { get; set; }
    }
}
