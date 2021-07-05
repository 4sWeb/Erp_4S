using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Accountingentrydetail
    {
        public decimal Accountingentrydetailsid { get; set; }
        public decimal? Entryid { get; set; }
        public string Aremarks { get; set; }
        public string Eremarks { get; set; }
        public decimal? Accountid { get; set; }
        public decimal? Costcenterid { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }

        public virtual Account Account { get; set; }
        public virtual Costcenter Costcenter { get; set; }
        public virtual Accountingentry Entry { get; set; }
    }
}
