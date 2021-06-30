using System;
using System.Collections.Generic;

namespace ERPCOREDAL.Models
{
    public partial class Istransfer
    {
        public Istransfer()
        {
            //Financespec = new HashSet<Financespec>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        public int Id { get; set; }

        //public virtual ICollection<Financespec> Financespec { get; set; }
    }
}
