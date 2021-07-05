using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SlidesStaff
    {
        public decimal Id { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? SlidesMId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string ApplyTo { get; set; }

        public virtual StoreAllcode StoreAllcodes { get; set; }
    }
}
