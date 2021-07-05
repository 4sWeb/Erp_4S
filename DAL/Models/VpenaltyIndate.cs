using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VpenaltyIndate
    {
        public DateTime? Indate { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal Id { get; set; }
        public decimal? Instval { get; set; }
        public string DocNo { get; set; }
        public decimal? Vfixedcost { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? PayedPenalty { get; set; }
        public string Serialname { get; set; }
        public string Serialename { get; set; }
        public string Instalmentname { get; set; }
        public string Instalmentename { get; set; }
        public decimal? Cratio { get; set; }
        public byte? Freeperiod { get; set; }
        public string Periodtype { get; set; }
        public decimal? Fixedcost { get; set; }
        public decimal? Mincharge { get; set; }
        public byte? Subserial { get; set; }
        public short? Overallserial { get; set; }
        public string Tableflag { get; set; }
        public decimal? Tableid { get; set; }
        public string Descr { get; set; }
        public byte? Rank { get; set; }
    }
}
