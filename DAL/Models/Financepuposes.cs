using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class Financepuposes
    {
        public Financepuposes()
        {
            //Financespec = new HashSet<Financespec>();
        }

        public int Id { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }

        //public virtual ICollection<Financespec> Financespec { get; set; }
    }
}
