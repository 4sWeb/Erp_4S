using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checkhistory
    {
        public decimal Checkid { get; set; }
        public string Checkno { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Rescheduled { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Currrate { get; set; }
        public decimal? CD { get; set; }
        public decimal Statusid { get; set; }
        public string Statusaname { get; set; }
        public DateTime? Hstamp { get; set; }
        public decimal Hafzamid { get; set; }
        public decimal Hafzatype { get; set; }
        public string Hafzatypeaname { get; set; }
    }
}
