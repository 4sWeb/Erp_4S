using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ShippingSpec
    {
        public decimal Id { get; set; }
        public decimal? TransCode { get; set; }
        public decimal? MainTypeId { get; set; }
        public bool? Priceinship { get; set; }
        public bool? Driverinform { get; set; }
        public bool? Areainform { get; set; }
        public bool? Issidschange { get; set; }
        public bool? Carinform { get; set; }
        public bool? Customercode { get; set; }
        public bool? Shippingvalue { get; set; }
        public bool? Moreshipmove { get; set; }
        public bool? Shippingnotes { get; set; }
        public bool? Taxshipping { get; set; }
        public bool? Otherdriverinform { get; set; }
        public int? Areainformcode { get; set; }
        public int? Taximpact { get; set; }
        public int? Costcode { get; set; }

        public virtual StoreTrn TransCodeNavigation { get; set; }
    }
}
