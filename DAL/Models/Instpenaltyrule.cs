using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Instpenaltyrule
    {
        public Instpenaltyrule()
        {
            Institemspenaltyrules = new HashSet<Institemspenaltyrule>();
        }

        public decimal Id { get; set; }
        public decimal? Businessid { get; set; }
        public string ApplyTo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Cratio { get; set; }
        public byte? Freeperiod { get; set; }
        public string Periodtype { get; set; }
        public decimal? Fixedcost { get; set; }
        public decimal? Mincharge { get; set; }
        public string Penaltytype { get; set; }
        public decimal? Penaltycount { get; set; }

        public virtual ICollection<Institemspenaltyrule> Institemspenaltyrules { get; set; }
    }
}
