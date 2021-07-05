using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ServicesHold
    {
        public decimal Id { get; set; }
        public decimal? Servicesid { get; set; }
        public DateTime? Transdate { get; set; }
        public string Transtype { get; set; }
        public string Notes { get; set; }
        public decimal? Unitid { get; set; }

        public virtual ServicesType Services { get; set; }
        public virtual ServicesInstitem Unit { get; set; }
    }
}
