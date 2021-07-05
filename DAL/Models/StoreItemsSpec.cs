using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemsSpec
    {
        public decimal StoreItemsSpecId { get; set; }
        public decimal? StoreItemsId { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public decimal? GroupBasicId { get; set; }

        public virtual StoreItem StoreItems { get; set; }
    }
}
