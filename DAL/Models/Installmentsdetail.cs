using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Installmentsdetail
    {
        public decimal? Saleformid { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Valueofbenefits { get; set; }
        public decimal? Instval { get; set; }
        public short? Internalinterval { get; set; }
        public string Internalintervaltype { get; set; }
        public byte? Instcount { get; set; }
        public string Curraname { get; set; }
        public string Currename { get; set; }
        public string SerialName { get; set; }
        public string SerialEname { get; set; }
        public string IsContract { get; set; }
        public string IsReserve { get; set; }
        public string IsEnd { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Endtdate { get; set; }
        public string Insttype { get; set; }
    }
}
