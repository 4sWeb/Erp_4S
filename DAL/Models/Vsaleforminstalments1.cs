using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vsaleforminstalments1
    {
        public DateTime? Dd { get; set; }
        public decimal? Saleformid { get; set; }
        public short? Overallserial { get; set; }
        public decimal? Flag { get; set; }
        public DateTime? Indate { get; set; }
        public DateTime? InstIndate { get; set; }
        public string Description { get; set; }
        public string Edescription { get; set; }
        public decimal? Instval { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? Vfixedcost { get; set; }
        public decimal? Payed { get; set; }
        public decimal? PayedPenalty { get; set; }
        public decimal? PayedFixedcost { get; set; }
        public decimal? Earlydiscount { get; set; }
        public decimal Instid { get; set; }
        public decimal? Trnsno { get; set; }
        public string Tableflag { get; set; }
    }
}
