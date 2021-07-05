using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Dependencytreereport
    {
        public string Deptrnsaname { get; set; }
        public string Deptrnsename { get; set; }
        public string Depontrnsaname { get; set; }
        public string Depontrnsename { get; set; }
        public decimal? Deptrnsnum { get; set; }
        public decimal? Depontrnsnum { get; set; }
        public decimal? Userid { get; set; }
        public decimal Id { get; set; }

        public virtual User User { get; set; }
    }
}
