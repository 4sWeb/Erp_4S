using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstChecksUnderCollection
    {
        public DateTime? Dd { get; set; }
        public decimal? Checkid { get; set; }
        public decimal? Instalmentid { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Fval { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Currrate { get; set; }
        public string Checkno { get; set; }
        public DateTime? Duedate { get; set; }
    }
}
