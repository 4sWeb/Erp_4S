using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SecurityField
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public int? Flag { get; set; }
        public decimal? Application { get; set; }
        public decimal? Parentid { get; set; }
    }
}
