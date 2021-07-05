using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Entrytype
    {
        public Entrytype()
        {
            Accountingentries = new HashSet<Accountingentry>();
        }

        public decimal Entrytypeid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Accountingentry> Accountingentries { get; set; }
    }
}
