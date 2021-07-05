using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vgetinstprogram
    {
        public decimal Instid { get; set; }
        public string Instname { get; set; }
        public string Instpartname { get; set; }
        public byte? Instcount { get; set; }
        public decimal? Instpercent { get; set; }
        public byte? Rank { get; set; }
    }
}
