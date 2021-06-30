using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCOREDAL.Models
{
    public partial class Financetype
    {
        public Financetype()
        {
            //Financespec = new HashSet<Financespec>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        [Key]
        public int RowId { get; set; }

        //public virtual ICollection<Financespec> Financespec { get; set; }
    }
}
