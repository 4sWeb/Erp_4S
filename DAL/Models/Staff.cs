using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class staff
    {
        public staff()
        {
            ReservedUnits = new HashSet<ReservedUnit>();
        }

        public decimal Id { get; set; }
        public decimal? Personid { get; set; }
        public decimal? Staffclassid { get; set; }
        public decimal? Subclassid { get; set; }
        public decimal? Supervisorid { get; set; }
        public decimal? Stafflevelid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Managerid { get; set; }

        public virtual StoreAllcode Person { get; set; }
        public virtual Staffclass Staffclass { get; set; }
        public virtual Stafflevel Stafflevel { get; set; }
        public virtual Staffsubclass Subclass { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ReservedUnit> ReservedUnits { get; set; }
    }
}
