using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Journalentriesdimension
    {
        public decimal Id { get; set; }
        public decimal? Dimensiondetailsid { get; set; }
        public decimal? Journalentriesdetailsid { get; set; }

        public virtual Dimensionsdetail Dimensiondetails { get; set; }
        public virtual Journalentriesdetail Journalentriesdetails { get; set; }
    }
}
