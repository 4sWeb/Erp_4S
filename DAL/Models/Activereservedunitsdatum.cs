using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Activereservedunitsdatum
    {
        public decimal Id { get; set; }
        public decimal? Institemid { get; set; }
        public decimal? Compositeid { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? ReservedBy { get; set; }
        public decimal? AreservedFor { get; set; }
        public string EreservedFor { get; set; }
        public string Active { get; set; }
        public decimal? Userid { get; set; }
        public DateTime? Todate { get; set; }
        public string Areservedfor1 { get; set; }
        public string Areservedforen { get; set; }
        public string Institemcode { get; set; }
        public string Reservedby1 { get; set; }
        public string Reservedbyen { get; set; }
        public bool? Reservebydeposit { get; set; }
        public decimal? Depositvalue { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Campcode { get; set; }
        public decimal? Campresource { get; set; }
        public decimal? Rep2 { get; set; }
    }
}
