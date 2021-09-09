using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItem
    {
        public StoreItem()
        {
            AgridatumItems = new HashSet<Agridatum>();
            AgridatumPreviousitems = new HashSet<Agridatum>();
            Codeslinkitemdetails = new HashSet<Codeslinkitemdetail>();
            EvaluaPricePromationDetails = new HashSet<EvaluaPricePromationDetail>();
            FinanceAnlsCodesFactors = new HashSet<FinanceAnlsCodesFactor>();
            IntgAcccodesDetails = new HashSet<IntgAcccodesDetail>();
            ItemChangePriceOs = new HashSet<ItemChangePriceO>();
            ItemDiscountOs = new HashSet<ItemDiscountO>();
            Productformladetails = new HashSet<Productformladetail>();
            Productstages = new HashSet<Productstage>();
            Reservationitems = new HashSet<Reservationitem>();
            StoreAllsubcodes = new HashSet<StoreAllsubcode>();
            StoreInventoryOs = new HashSet<StoreInventoryO>();
            StoreItemBranchPrices = new HashSet<StoreItemBranchPrice>();
            StoreItemPrices = new HashSet<StoreItemPrice>();
            StoreItemUnits = new HashSet<StoreItemUnit>();
            StoreItemsBals = new HashSet<StoreItemsBal>();
            StoreItemsDocattachments = new HashSet<StoreItemsDocattachment>();
            StoreItemsSpecs = new HashSet<StoreItemsSpec>();
            StoreItemsingreds = new HashSet<StoreItemsingred>();
            StoreTrnsOTemps = new HashSet<StoreTrnsOTemp>();
            StoreTrnsOs = new HashSet<StoreTrnsO>();
            StoreTrnsPrices = new HashSet<StoreTrnsPrice>();
            StoreTrnsProducationformlas = new HashSet<StoreTrnsProducationformla>();
            Storeitemsallcodes = new HashSet<Storeitemsallcode>();
            //StoreItemfromsSpecs = new HashSet<StoreItemformsSpec>();
        }

        public string ItemCode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Saname { get; set; }
        public string Sename { get; set; }
        public decimal? IPurchPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? BranchPrice { get; set; }
        public decimal? DealPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? SalesTaxPercent { get; set; }
        public decimal StoreItemsId { get; set; }
        public decimal? StoreItemfromsSpecsId { get; set; }
        public decimal? RetailPrice { get; set; }
        public bool? Isstoped { get; set; }
        public string Notes { get; set; }
        public string Notese { get; set; }
        public string Itembarcode { get; set; }

        public virtual  StoreItemformsSpec StoreItemfromsSpecs { get; set; }
        public virtual ICollection<Agridatum> AgridatumItems { get; set; }
        public virtual ICollection<Agridatum> AgridatumPreviousitems { get; set; }
        public virtual ICollection<Codeslinkitemdetail> Codeslinkitemdetails { get; set; }
        public virtual ICollection<EvaluaPricePromationDetail> EvaluaPricePromationDetails { get; set; }
        public virtual ICollection<FinanceAnlsCodesFactor> FinanceAnlsCodesFactors { get; set; }
        public virtual ICollection<IntgAcccodesDetail> IntgAcccodesDetails { get; set; }
        public virtual ICollection<ItemChangePriceO> ItemChangePriceOs { get; set; }
        public virtual ICollection<ItemDiscountO> ItemDiscountOs { get; set; }
        public virtual ICollection<Productformladetail> Productformladetails { get; set; }
        public virtual ICollection<Productstage> Productstages { get; set; }
        public virtual ICollection<Reservationitem> Reservationitems { get; set; }
        public virtual ICollection<StoreAllsubcode> StoreAllsubcodes { get; set; }
        public virtual ICollection<StoreInventoryO> StoreInventoryOs { get; set; }
        public virtual ICollection<StoreItemBranchPrice> StoreItemBranchPrices { get; set; }
        public virtual ICollection<StoreItemPrice> StoreItemPrices { get; set; }
        public virtual ICollection<StoreItemUnit> StoreItemUnits { get; set; }
        public virtual ICollection<StoreItemsBal> StoreItemsBals { get; set; }
        public virtual ICollection<StoreItemsDocattachment> StoreItemsDocattachments { get; set; }
        public virtual ICollection<StoreItemsSpec> StoreItemsSpecs { get; set; }
        public virtual ICollection<StoreItemsingred> StoreItemsingreds { get; set; }
        public virtual ICollection<StoreTrnsOTemp> StoreTrnsOTemps { get; set; }
        public virtual ICollection<StoreTrnsO> StoreTrnsOs { get; set; }
        public virtual ICollection<StoreTrnsPrice> StoreTrnsPrices { get; set; }
        public virtual ICollection<StoreTrnsProducationformla> StoreTrnsProducationformlas { get; set; }
        public virtual ICollection<Storeitemsallcode> Storeitemsallcodes { get; set; }
    }
}
