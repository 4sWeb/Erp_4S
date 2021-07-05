using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ItemChangePriceM
    {
        public ItemChangePriceM()
        {
            ItemChangePriceOs = new HashSet<ItemChangePriceO>();
            ItemchangemStoreTrns = new HashSet<ItemchangemStoreTrn>();
            PriceListMaxQuantities = new HashSet<PriceListMaxQuantity>();
        }

        public decimal Itemchangeid { get; set; }
        public string Itemchangcode { get; set; }
        public string Itemchangeremark { get; set; }
        public decimal? GroupfId { get; set; }
        public decimal? PriceTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual PriceListType PriceType { get; set; }
        public virtual ICollection<ItemChangePriceO> ItemChangePriceOs { get; set; }
        public virtual ICollection<ItemchangemStoreTrn> ItemchangemStoreTrns { get; set; }
        public virtual ICollection<PriceListMaxQuantity> PriceListMaxQuantities { get; set; }
    }
}
