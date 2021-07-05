using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Userreport
    {
        public decimal? Userid { get; set; }
        public decimal? Reportid { get; set; }
        public decimal? Period { get; set; }
        public string Periodtype { get; set; }
        public decimal Id { get; set; }

        public virtual User User { get; set; }
    }
}
