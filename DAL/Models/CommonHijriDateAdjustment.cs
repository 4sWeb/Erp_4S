using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CommonHijriDateAdjustment
    {
        public decimal Id { get; set; }
        public long? Value { get; set; }
        public DateTime? Hijridate { get; set; }
        public DateTime? Miladidate { get; set; }
    }
}
