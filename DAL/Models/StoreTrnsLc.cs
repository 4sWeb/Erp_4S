using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsLc
    {
        public StoreTrnsLc()
        {
            StoreTrnsLcDocuments = new HashSet<StoreTrnsLcDocument>();
        }

        public decimal Id { get; set; }
        public decimal? StoreTrnsmId { get; set; }
        public string Refno { get; set; }
        public bool? Ordercase { get; set; }
        public decimal? Shippingway { get; set; }
        public decimal? Shippingcompany { get; set; }
        public decimal? Readyforshipping { get; set; }
        public decimal? Insurancedoc { get; set; }
        public bool? Payment { get; set; }
        public decimal? Baseofcontract { get; set; }
        public string Shippedvia { get; set; }
        public decimal? Origincountry { get; set; }
        public decimal? Shippingplace { get; set; }
        public string Inaddress { get; set; }
        public DateTime? Expshipmentdate { get; set; }
        public DateTime? Acknoweldgedate { get; set; }
        public bool? Partialshipment { get; set; }
        public decimal? Bankid { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Exworkvalue { get; set; }
        public decimal? Insurancevalue { get; set; }
        public decimal? Inlandvalue { get; set; }
        public decimal? Fierghtvalue { get; set; }
        public decimal? Amountdue { get; set; }

        public virtual StoreAllcode Bank { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual StoreAllsubcode OrigincountryNavigation { get; set; }
        public virtual StoreAllsubcode ShippingcompanyNavigation { get; set; }
        public virtual StoreAllsubcode ShippingplaceNavigation { get; set; }
        public virtual StoreAllsubcode ShippingwayNavigation { get; set; }
        public virtual StoreTrnsM StoreTrnsm { get; set; }
        public virtual ICollection<StoreTrnsLcDocument> StoreTrnsLcDocuments { get; set; }
    }
}
