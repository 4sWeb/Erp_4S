using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CommonRegion
    {
        public decimal Id { get; set; }
        public string Description { get; set; }
        public decimal? Country { get; set; }
        public string Code { get; set; }
    }
}
