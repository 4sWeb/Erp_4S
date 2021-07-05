using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Generalspec
    {
        public Generalspec()
        {
            Accounts = new HashSet<Account>();
            Costcenters = new HashSet<Costcenter>();
            Generalspecsdetails = new HashSet<Generalspecsdetail>();
        }

        public decimal Specid { get; set; }
        public decimal? Levels { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Costcenter> Costcenters { get; set; }
        public virtual ICollection<Generalspecsdetail> Generalspecsdetails { get; set; }
    }
}
