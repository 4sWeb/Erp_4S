using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cminstitemfeature
    {
        public decimal Id { get; set; }
        public decimal? InstitemId { get; set; }
        public decimal? Compositeid { get; set; }
        public decimal? FeatureId { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Unitval2 { get; set; }
        public decimal? Quantity3 { get; set; }
        public decimal? Unitval3 { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public string Sperateinstalments { get; set; }
        public string Pricelistsubject { get; set; }
        public decimal? InstprogramsId { get; set; }
        public decimal? Ownercompany { get; set; }

        public virtual Institemmaintypefeature Feature { get; set; }
        public virtual Instprogram Instprograms { get; set; }
        public virtual StoreAllsubcode OwnercompanyNavigation { get; set; }
    }
}
