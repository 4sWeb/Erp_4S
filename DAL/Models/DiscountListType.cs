using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DiscountListType
    {
        public DiscountListType()
        {
            DiscountItemMs = new HashSet<DiscountItemM>();
            DiscountListCustomers = new HashSet<DiscountListCustomer>();
        }

        public decimal DiscountListId { get; set; }
        public string DiscountCode { get; set; }
        public string Descripation { get; set; }
        public string Engdesc { get; set; }

        public virtual ICollection<DiscountItemM> DiscountItemMs { get; set; }
        public virtual ICollection<DiscountListCustomer> DiscountListCustomers { get; set; }
    }
}
