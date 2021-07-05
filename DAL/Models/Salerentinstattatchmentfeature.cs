using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Salerentinstattatchmentfeature
    {
        public decimal Id { get; set; }
        public decimal? InstitemId { get; set; }
        public decimal? AttatchmentId { get; set; }
        public decimal? FeatureId { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public string Valueorratio1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Unitval2 { get; set; }
        public string Valueorratio2 { get; set; }
        public decimal? Quantity3 { get; set; }
        public decimal? Unitval3 { get; set; }
        public string Valueorratio3 { get; set; }
        public decimal? InstcalcmethodId { get; set; }

        public virtual Institemattatchment Attatchment { get; set; }
        public virtual Attachmentfeature Feature { get; set; }
        public virtual Instcalcmethod Instcalcmethod { get; set; }
        public virtual Salerentinstitem Institem { get; set; }
    }
}
