using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checksmod
    {
        public decimal Id { get; set; }
        public string Checkno { get; set; }
        public DateTime? Period { get; set; }
        public decimal? Duedate { get; set; }
        public decimal? Purpose { get; set; }
        public string Beneficiary { get; set; }
        public decimal? Grossval { get; set; }
    }
}
