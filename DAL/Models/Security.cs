using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Security
    {
        public decimal Securityid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Pageid { get; set; }
        public string Permission { get; set; }

        public virtual User User { get; set; }
    }
}
