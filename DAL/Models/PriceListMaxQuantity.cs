using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PriceListMaxQuantity
    {
        public decimal Id { get; set; }
        public decimal? Itemchangeid { get; set; }
        public decimal? StoreAllsubcodesId { get; set; }
        public decimal? MainTypes { get; set; }
        public decimal? PartId { get; set; }
        public string PartCode { get; set; }
        public decimal? Value { get; set; }

        public virtual ItemChangePriceM Itemchange { get; set; }
        public virtual MainType MainTypesNavigation { get; set; }
        public virtual StoreAllsubcode StoreAllsubcodes { get; set; }
    }
}
