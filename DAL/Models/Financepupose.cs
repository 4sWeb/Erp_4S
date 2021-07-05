using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financepupose
    {
        public Financepupose()
        {
            Financems = new HashSet<Financem>();
            Financespecs = new HashSet<Financespec>();
        }

        public decimal Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        public virtual ICollection<Financem> Financems { get; set; }
        public virtual ICollection<Financespec> Financespecs { get; set; }
    }
}
