using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Estimatedval
    {
        public Estimatedval()
        {
            Estimatedvalsdets = new HashSet<Estimatedvalsdet>();
        }

        public decimal Id { get; set; }
        public decimal? Periodid { get; set; }
        public decimal? Acctreeid { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public decimal? Debitval { get; set; }
        public decimal? Creditval { get; set; }

        public virtual Accountstree Acctree { get; set; }
        public virtual Period Period { get; set; }
        public virtual ICollection<Estimatedvalsdet> Estimatedvalsdets { get; set; }
    }
}
