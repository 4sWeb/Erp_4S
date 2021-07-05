using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Instproramsview
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Insttype { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public string Descr { get; set; }
        public string Edescr { get; set; }
        public byte? Instcount { get; set; }
        public decimal? Instpercent { get; set; }
        public decimal? Instval { get; set; }
        public short? Internalinterval { get; set; }
        public string Internalintervaltype { get; set; }
        public short? Externalinterval { get; set; }
        public string Externalintervaltype { get; set; }
        public string Externalbegintype { get; set; }
        public decimal Instmid { get; set; }
    }
}
