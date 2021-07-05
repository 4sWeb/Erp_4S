using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstalmentsM
    {
        public decimal Id { get; set; }
        public decimal? Instprogramid { get; set; }
        public decimal? Instalmentpartid { get; set; }
        public byte? Rank { get; set; }
        public byte? Instcount { get; set; }
        public decimal? Instpercent { get; set; }
        public short? Internalinterval { get; set; }
        public string Internalintervaltype { get; set; }
        public short? Externalinterval { get; set; }
        public string Externalintervaltype { get; set; }
        public string Externalbegintype { get; set; }

        public virtual Instalmentpart Instalmentpart { get; set; }
        public virtual Instprogram Instprogram { get; set; }
    }
}
