using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Finalmiagrationtype
    {
        public Finalmiagrationtype()
        {
            Accounts = new HashSet<Account>();
        }

        public decimal Finalmiagrationid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? Levelfinalmiagration { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
