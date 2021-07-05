using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Rentformcompositeitem
    {
        public decimal Id { get; set; }
        public decimal? Rentformid { get; set; }
        public decimal? Composititemid { get; set; }
    }
}
