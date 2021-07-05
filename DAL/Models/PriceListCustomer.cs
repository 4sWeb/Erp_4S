using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PriceListCustomer
    {
        public PriceListCustomer()
        {
            PriceListCustomerOs = new HashSet<PriceListCustomerO>();
        }

        public decimal Id { get; set; }
        public decimal? CustomerId { get; set; }
        public decimal? PriceTypeId { get; set; }

        public virtual StoreAllcode Customer { get; set; }
        public virtual PriceListType PriceType { get; set; }
        public virtual ICollection<PriceListCustomerO> PriceListCustomerOs { get; set; }
    }
}
