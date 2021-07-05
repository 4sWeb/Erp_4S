using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GlCurrency
    {
        public decimal Id { get; set; }
        public string Ardesc { get; set; }
        public string Endesc { get; set; }
        public string Symbol { get; set; }
        public decimal? Rate { get; set; }
        public bool? Islocked { get; set; }
        public bool? Islocalcurrency { get; set; }
    }
}
