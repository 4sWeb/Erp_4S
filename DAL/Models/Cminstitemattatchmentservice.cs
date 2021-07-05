using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cminstitemattatchmentservice
    {
        public decimal Id { get; set; }
        public decimal? InstitemId { get; set; }
        public decimal? Compositeid { get; set; }
        public decimal? AttatchmentId { get; set; }
        public decimal? ServiceId { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public string Valueorratio1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Unitval2 { get; set; }
        public string Valueorratio2 { get; set; }
        public decimal? Quantity3 { get; set; }
        public decimal? Unitval3 { get; set; }
        public string Valueorratio3 { get; set; }

        public virtual Attachmentservice Service { get; set; }
    }
}
