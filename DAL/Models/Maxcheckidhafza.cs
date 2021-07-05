using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Maxcheckidhafza
    {
        public DateTime Dd { get; set; }
        public decimal Checkid { get; set; }
        public DateTime? Hstamp { get; set; }
        public DateTime? Hafzadate { get; set; }
        public decimal Id { get; set; }
        public decimal? Hafzatype { get; set; }
    }
}
