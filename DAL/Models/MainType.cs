using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class MainType
    {
        public MainType()
        {
            BusinesstypeSpecs = new HashSet<BusinesstypeSpec>();
            Codeslinks = new HashSet<Codeslink>();
            GroupfDetails = new HashSet<GroupfDetail>();
            Groupfs = new HashSet<Groupf>();
            Institemmaintypesproperties = new HashSet<Institemmaintypesproperty>();
            PriceListMaxQuantities = new HashSet<PriceListMaxQuantity>();
            StoreAllsubcodes = new HashSet<StoreAllsubcode>();
            StoreTrns = new HashSet<StoreTrn>();
            UsersStoreAllcodes = new HashSet<UsersStoreAllcode>();
        }

        public string Aname { get; set; }
        public string Ename { get; set; }
        public byte Length { get; set; }
        public string Kind { get; set; }
        public bool System { get; set; }
        public decimal Id { get; set; }

        public virtual ICollection<BusinesstypeSpec> BusinesstypeSpecs { get; set; }
        public virtual ICollection<Codeslink> Codeslinks { get; set; }
        public virtual ICollection<GroupfDetail> GroupfDetails { get; set; }
        public virtual ICollection<Groupf> Groupfs { get; set; }
        public virtual ICollection<Institemmaintypesproperty> Institemmaintypesproperties { get; set; }
        public virtual ICollection<PriceListMaxQuantity> PriceListMaxQuantities { get; set; }
        public virtual ICollection<StoreAllsubcode> StoreAllsubcodes { get; set; }
        public virtual ICollection<StoreTrn> StoreTrns { get; set; }
        public virtual ICollection<UsersStoreAllcode> UsersStoreAllcodes { get; set; }
    }
}
