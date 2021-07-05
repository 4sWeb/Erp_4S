using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PriceListType
    {
        public PriceListType()
        {
            ItemChangePriceMs = new HashSet<ItemChangePriceM>();
            PriceListCustomers = new HashSet<PriceListCustomer>();
        }

        public decimal PriceTypeId { get; set; }
        public string PriceCode { get; set; }
        public string Descripation { get; set; }
        public string Engdesc { get; set; }

        public virtual ICollection<ItemChangePriceM> ItemChangePriceMs { get; set; }
        public virtual ICollection<PriceListCustomer> PriceListCustomers { get; set; }
    }
}
