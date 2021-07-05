using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreAllsubcode
    {
        public StoreAllsubcode()
        {
            AgridatumAgrioriginNavigations = new HashSet<Agridatum>();
            AgridatumAgriways = new HashSet<Agridatum>();
            AgridatumRaises = new HashSet<Agridatum>();
            AssetCurrbranches = new HashSet<Asset>();
            AssetFirstbranches = new HashSet<Asset>();
            Checks = new HashSet<Check>();
            Cminstitemattatchments = new HashSet<Cminstitemattatchment>();
            Cminstitembuildinglayers = new HashSet<Cminstitembuildinglayer>();
            Cminstitemfeatures = new HashSet<Cminstitemfeature>();
            Cminstitemlayoutdetails = new HashSet<Cminstitemlayoutdetail>();
            Cminstitemproperties = new HashSet<Cminstitemproperty>();
            Cminstitemservices = new HashSet<Cminstitemservice>();
            Codelinkpartdetails = new HashSet<Codelinkpartdetail>();
            Compositeinstitems = new HashSet<Compositeinstitem>();
            Financems = new HashSet<Financem>();
            Hafzams = new HashSet<Hafzam>();
            InstitemBuyerNavigations = new HashSet<Institem>();
            InstitemBuyermethodNavigations = new HashSet<Institem>();
            InstitemOwnerNavigations = new HashSet<Institem>();
            InstitemPaymethodNavigations = new HashSet<Institem>();
            Institemcompinstpays = new HashSet<Institemcompinstpay>();
            Institemmaintypes = new HashSet<Institemmaintype>();
            PriceListMaxQuantities = new HashSet<PriceListMaxQuantity>();
            RentformBranches = new HashSet<Rentform>();
            RentformFormstatustypesNavigations = new HashSet<Rentform>();
            RentformItemactivitytypeNavigations = new HashSet<Rentform>();
            ReservedUnitCampcodeNavigations = new HashSet<ReservedUnit>();
            ReservedUnitCampresourceNavigations = new HashSet<ReservedUnit>();
            SaleformBranches = new HashSet<Saleform>();
            SaleformCampcodeNavigations = new HashSet<Saleform>();
            SaleformCampresourceNavigations = new HashSet<Saleform>();
            SaleformFormstatustypesNavigations = new HashSet<Saleform>();
            SaleformFormtypeNavigations = new HashSet<Saleform>();
            SaleformItemactivitytypeNavigations = new HashSet<Saleform>();
            ServicesInstitems = new HashSet<ServicesInstitem>();
            ServicesPriceLayoutNavigations = new HashSet<ServicesPrice>();
            ServicesPriceParts = new HashSet<ServicesPrice>();
            StoreInventoryMs = new HashSet<StoreInventoryM>();
            StoreItemBranchPrices = new HashSet<StoreItemBranchPrice>();
            StoreItemsingreds = new HashSet<StoreItemsingred>();
            StoreTrnsLcOrigincountryNavigations = new HashSet<StoreTrnsLc>();
            StoreTrnsLcShippingcompanyNavigations = new HashSet<StoreTrnsLc>();
            StoreTrnsLcShippingplaceNavigations = new HashSet<StoreTrnsLc>();
            StoreTrnsLcShippingwayNavigations = new HashSet<StoreTrnsLc>();
            StoreTrnsMTemps = new HashSet<StoreTrnsMTemp>();
            StoreTrnsMs = new HashSet<StoreTrnsM>();
            StoreTrnsOs = new HashSet<StoreTrnsO>();
        }

        public decimal Codetype { get; set; }
        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal StoreAllsubcodesId { get; set; }
        public string FullCode { get; set; }
        public decimal? StoreAllsubcodesOriginalId { get; set; }
        public string Phoneno { get; set; }
        public string Faxno { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Addresse { get; set; }
        public string Rep { get; set; }
        public string Repe { get; set; }
        public string Note1 { get; set; }
        public string Note1e { get; set; }
        public string Note2 { get; set; }
        public string Note2e { get; set; }
        public decimal? Defaultitemid { get; set; }

        public virtual MainType CodetypeNavigation { get; set; }
        public virtual StoreItem Defaultitem { get; set; }
        public virtual BusinesstypeSpec BusinesstypeSpec { get; set; }
        public virtual ICollection<Agridatum> AgridatumAgrioriginNavigations { get; set; }
        public virtual ICollection<Agridatum> AgridatumAgriways { get; set; }
        public virtual ICollection<Agridatum> AgridatumRaises { get; set; }
        public virtual ICollection<Asset> AssetCurrbranches { get; set; }
        public virtual ICollection<Asset> AssetFirstbranches { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<Cminstitemattatchment> Cminstitemattatchments { get; set; }
        public virtual ICollection<Cminstitembuildinglayer> Cminstitembuildinglayers { get; set; }
        public virtual ICollection<Cminstitemfeature> Cminstitemfeatures { get; set; }
        public virtual ICollection<Cminstitemlayoutdetail> Cminstitemlayoutdetails { get; set; }
        public virtual ICollection<Cminstitemproperty> Cminstitemproperties { get; set; }
        public virtual ICollection<Cminstitemservice> Cminstitemservices { get; set; }
        public virtual ICollection<Codelinkpartdetail> Codelinkpartdetails { get; set; }
        public virtual ICollection<Compositeinstitem> Compositeinstitems { get; set; }
        public virtual ICollection<Financem> Financems { get; set; }
        public virtual ICollection<Hafzam> Hafzams { get; set; }
        public virtual ICollection<Institem> InstitemBuyerNavigations { get; set; }
        public virtual ICollection<Institem> InstitemBuyermethodNavigations { get; set; }
        public virtual ICollection<Institem> InstitemOwnerNavigations { get; set; }
        public virtual ICollection<Institem> InstitemPaymethodNavigations { get; set; }
        public virtual ICollection<Institemcompinstpay> Institemcompinstpays { get; set; }
        public virtual ICollection<Institemmaintype> Institemmaintypes { get; set; }
        public virtual ICollection<PriceListMaxQuantity> PriceListMaxQuantities { get; set; }
        public virtual ICollection<Rentform> RentformBranches { get; set; }
        public virtual ICollection<Rentform> RentformFormstatustypesNavigations { get; set; }
        public virtual ICollection<Rentform> RentformItemactivitytypeNavigations { get; set; }
        public virtual ICollection<ReservedUnit> ReservedUnitCampcodeNavigations { get; set; }
        public virtual ICollection<ReservedUnit> ReservedUnitCampresourceNavigations { get; set; }
        public virtual ICollection<Saleform> SaleformBranches { get; set; }
        public virtual ICollection<Saleform> SaleformCampcodeNavigations { get; set; }
        public virtual ICollection<Saleform> SaleformCampresourceNavigations { get; set; }
        public virtual ICollection<Saleform> SaleformFormstatustypesNavigations { get; set; }
        public virtual ICollection<Saleform> SaleformFormtypeNavigations { get; set; }
        public virtual ICollection<Saleform> SaleformItemactivitytypeNavigations { get; set; }
        public virtual ICollection<ServicesInstitem> ServicesInstitems { get; set; }
        public virtual ICollection<ServicesPrice> ServicesPriceLayoutNavigations { get; set; }
        public virtual ICollection<ServicesPrice> ServicesPriceParts { get; set; }
        public virtual ICollection<StoreInventoryM> StoreInventoryMs { get; set; }
        public virtual ICollection<StoreItemBranchPrice> StoreItemBranchPrices { get; set; }
        public virtual ICollection<StoreItemsingred> StoreItemsingreds { get; set; }
        public virtual ICollection<StoreTrnsLc> StoreTrnsLcOrigincountryNavigations { get; set; }
        public virtual ICollection<StoreTrnsLc> StoreTrnsLcShippingcompanyNavigations { get; set; }
        public virtual ICollection<StoreTrnsLc> StoreTrnsLcShippingplaceNavigations { get; set; }
        public virtual ICollection<StoreTrnsLc> StoreTrnsLcShippingwayNavigations { get; set; }
        public virtual ICollection<StoreTrnsMTemp> StoreTrnsMTemps { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMs { get; set; }
        public virtual ICollection<StoreTrnsO> StoreTrnsOs { get; set; }
    }
}
