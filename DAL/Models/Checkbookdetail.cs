using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checkbookdetail
    {
        public decimal Id { get; set; }
        public decimal? Checkbookid { get; set; }
        public string Checknum { get; set; }

        public virtual Checkbook Checkbook { get; set; }
    }
}
