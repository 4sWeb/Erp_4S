using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PenaltyCriticalDate
    {
        public DateTime? Indate { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Instid { get; set; }
        public decimal? Flag { get; set; }
        public string DocNo { get; set; }
    }
}
