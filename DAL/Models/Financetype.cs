using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financetype
    {
        public Financetype()
        {
            Checks = new HashSet<Check>();
            Financespecs = new HashSet<Financespec>();
            Hafzams = new HashSet<Hafzam>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal RowId { get; set; }

        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<Financespec> Financespecs { get; set; }
        public virtual ICollection<Hafzam> Hafzams { get; set; }
    }
}
