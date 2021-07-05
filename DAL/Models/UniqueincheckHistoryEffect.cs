using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class UniqueincheckHistoryEffect
    {
        public decimal? Other { get; set; }
        public decimal Checkid { get; set; }
        public decimal Hafzamid { get; set; }
        public decimal Distid { get; set; }
        public decimal Maintypeid { get; set; }
    }
}
