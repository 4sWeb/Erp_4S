using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Printcheckssettingdetail
    {
        public decimal Id { get; set; }
        public decimal? Printchecksettingid { get; set; }
        public decimal? Controlid { get; set; }
        public decimal? Controlvisiable { get; set; }
        public decimal? Controltop { get; set; }
        public decimal? Controlleft { get; set; }
        public decimal? Controwidth { get; set; }
        public decimal? Controllines { get; set; }

        public virtual Printcheckscontrolsname Control { get; set; }
        public virtual Printcheckssetting Printchecksetting { get; set; }
    }
}
