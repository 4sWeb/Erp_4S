using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DiscountListCustomer
    {
        public decimal Id { get; set; }
        public decimal CustomerId { get; set; }
        public decimal DiscountTypeId { get; set; }

        public virtual StoreAllcode Customer { get; set; }
        public virtual DiscountListType DiscountType { get; set; }
    }
}
