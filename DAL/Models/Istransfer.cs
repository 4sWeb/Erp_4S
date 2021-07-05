using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Istransfer
    {
        public Istransfer()
        {
            Financespecs = new HashSet<Financespec>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal Id { get; set; }

        public virtual ICollection<Financespec> Financespecs { get; set; }
    }
}
