using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreAllcode
    {
        public StoreAllcode()
        {
            Agriages = new HashSet<Agriage>();
            Agridata = new HashSet<Agridatum>();
            Agriprocesses = new HashSet<Agriprocess>();
            AssetCurrdistinations = new HashSet<Asset>();
            AssetFirstdistinations = new HashSet<Asset>();
            Bankingfacilities = new HashSet<Bankingfacility>();
            CancellationorwaivertrnFinanceGuardianfromNavigations = new HashSet<Cancellationorwaivertrn>();
            CancellationorwaivertrnFinanceGuardiantoNavigations = new HashSet<Cancellationorwaivertrn>();
            CheckDebtors = new HashSet<Check>();
            CheckVendors = new HashSet<Check>();
            Checkbooks = new HashSet<Checkbook>();
            Cminstitembuildinglayers = new HashSet<Cminstitembuildinglayer>();
            Cminstitemtempletes = new HashSet<Cminstitemtemplete>();
            Codeslinkdetails = new HashSet<Codeslinkdetail>();
            Conditionsbooklets = new HashSet<Conditionsbooklet>();
            CustomerDimensionsdetails = new HashSet<CustomerDimensionsdetail>();
            DiscountListCustomers = new HashSet<DiscountListCustomer>();
            FinancemAnalyses = new HashSet<Financem>();
            FinancemFdists = new HashSet<Financem>();
            FinancemReps = new HashSet<Financem>();
            FinancemTdists = new HashSet<Financem>();
            FinancespecAnalyses = new HashSet<Financespec>();
            FinancespecFdists = new HashSet<Financespec>();
            FinancespecReps = new HashSet<Financespec>();
            FinancespecTdists = new HashSet<Financespec>();
            HafzamFdists = new HashSet<Hafzam>();
            HafzamTdists = new HashSet<Hafzam>();
            Institems = new HashSet<Institem>();
            IntgAcccodesDetails = new HashSet<IntgAcccodesDetail>();
            Irrigationemps = new HashSet<Irrigationemp>();
            Journalentriesdetails = new HashSet<Journalentriesdetail>();
            Journalentriesmains = new HashSet<Journalentriesmain>();
            LgTransactionEdits = new HashSet<LgTransactionEdit>();
            LgTransactions = new HashSet<LgTransaction>();
            PriceListCustomers = new HashSet<PriceListCustomer>();
            Rentforms = new HashSet<Rentform>();
            Reservationitems = new HashSet<Reservationitem>();
            ReservedUnits = new HashSet<ReservedUnit>();
            Saleforms = new HashSet<Saleform>();
            ServicesInstitemCustStoreAllcodesIdnewNavigations = new HashSet<ServicesInstitem>();
            ServicesInstitemMandatories = new HashSet<ServicesInstitem>();
            ServicesMetersReadings = new HashSet<ServicesMetersReading>();
            SlidesStaffs = new HashSet<SlidesStaff>();
            StoreAllcodesBegins = new HashSet<StoreAllcodesBegin>();
            StoreCustDepositCusts = new HashSet<StoreCustDeposit>();
            StoreCustDepositStores = new HashSet<StoreCustDeposit>();
            StoreInventoryMs = new HashSet<StoreInventoryM>();
            StoreItemsBals = new HashSet<StoreItemsBal>();
            StoreSubCodeSpecs = new HashSet<StoreSubCodeSpec>();
            StoreTrnCashes = new HashSet<StoreTrn>();
            StoreTrnFromStoreAllcodes = new HashSet<StoreTrn>();
            StoreTrnToStoreAllcodes = new HashSet<StoreTrn>();
            StoreTrnsExpTemps = new HashSet<StoreTrnsExpTemp>();
            StoreTrnsExps = new HashSet<StoreTrnsExp>();
            StoreTrnsLcs = new HashSet<StoreTrnsLc>();
            StoreTrnsMFromStoreAllcodes = new HashSet<StoreTrnsM>();
            StoreTrnsMTempFromStoreAllcodes = new HashSet<StoreTrnsMTemp>();
            StoreTrnsMTempToStoreAllcodes = new HashSet<StoreTrnsMTemp>();
            StoreTrnsMToStoreAllcodes = new HashSet<StoreTrnsM>();
            StoreTrnsMTypes = new HashSet<StoreTrnsM>();
            StoreTrnsODsts = new HashSet<StoreTrnsO>();
            StoreTrnsOInjures = new HashSet<StoreTrnsO>();
            StoreTrnsOTemps = new HashSet<StoreTrnsOTemp>();
            StoreTrnsPrices = new HashSet<StoreTrnsPrice>();
            Storeallcodesattachments = new HashSet<Storeallcodesattachment>();
            Storeitemsallcodes = new HashSet<Storeitemsallcode>();
            UsersStoreAllcodes = new HashSet<UsersStoreAllcode>();
        }

        public string Code { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal CashBeginDebit { get; set; }
        public decimal CashBeginCredit { get; set; }
        public decimal CheckBeginDebit { get; set; }
        public decimal CheckBeginCredit { get; set; }
        public decimal StoreAllcodesId { get; set; }
        public decimal? GroupfId { get; set; }
        public bool? Discdepend { get; set; }
        public decimal? Discount { get; set; }
        public bool? Isstoped { get; set; }
        public bool? Istax { get; set; }
        public decimal? Salestax { get; set; }
        public decimal? Cashlimit { get; set; }
        public int? PeriodLimit { get; set; }
        public bool? Isbalanced { get; set; }
        public DateTime? Createdate { get; set; }
        public decimal? Userid { get; set; }
        public decimal? StoreAllcodesOriginalId { get; set; }
        public decimal? StoreAllcodesIdCrm { get; set; }
        public bool? Availableforreservation { get; set; }
        public string Stoppednotes { get; set; }
        public bool? Storage { get; set; }
        public decimal? Storageid { get; set; }

        public virtual Groupf Groupf { get; set; }
        public virtual User User { get; set; }
        public virtual staff staff { get; set; }
        public virtual ICollection<Agriage> Agriages { get; set; }
        public virtual ICollection<Agridatum> Agridata { get; set; }
        public virtual ICollection<Agriprocess> Agriprocesses { get; set; }
        public virtual ICollection<Asset> AssetCurrdistinations { get; set; }
        public virtual ICollection<Asset> AssetFirstdistinations { get; set; }
        public virtual ICollection<Bankingfacility> Bankingfacilities { get; set; }
        public virtual ICollection<Cancellationorwaivertrn> CancellationorwaivertrnFinanceGuardianfromNavigations { get; set; }
        public virtual ICollection<Cancellationorwaivertrn> CancellationorwaivertrnFinanceGuardiantoNavigations { get; set; }
        public virtual ICollection<Check> CheckDebtors { get; set; }
        public virtual ICollection<Check> CheckVendors { get; set; }
        public virtual ICollection<Checkbook> Checkbooks { get; set; }
        public virtual ICollection<Cminstitembuildinglayer> Cminstitembuildinglayers { get; set; }
        public virtual ICollection<Cminstitemtemplete> Cminstitemtempletes { get; set; }
        public virtual ICollection<Codeslinkdetail> Codeslinkdetails { get; set; }
        public virtual ICollection<Conditionsbooklet> Conditionsbooklets { get; set; }
        public virtual ICollection<CustomerDimensionsdetail> CustomerDimensionsdetails { get; set; }
        public virtual ICollection<DiscountListCustomer> DiscountListCustomers { get; set; }
        public virtual ICollection<Financem> FinancemAnalyses { get; set; }
        public virtual ICollection<Financem> FinancemFdists { get; set; }
        public virtual ICollection<Financem> FinancemReps { get; set; }
        public virtual ICollection<Financem> FinancemTdists { get; set; }
        public virtual ICollection<Financespec> FinancespecAnalyses { get; set; }
        public virtual ICollection<Financespec> FinancespecFdists { get; set; }
        public virtual ICollection<Financespec> FinancespecReps { get; set; }
        public virtual ICollection<Financespec> FinancespecTdists { get; set; }
        public virtual ICollection<Hafzam> HafzamFdists { get; set; }
        public virtual ICollection<Hafzam> HafzamTdists { get; set; }
        public virtual ICollection<Institem> Institems { get; set; }
        public virtual ICollection<IntgAcccodesDetail> IntgAcccodesDetails { get; set; }
        public virtual ICollection<Irrigationemp> Irrigationemps { get; set; }
        public virtual ICollection<Journalentriesdetail> Journalentriesdetails { get; set; }
        public virtual ICollection<Journalentriesmain> Journalentriesmains { get; set; }
        public virtual ICollection<LgTransactionEdit> LgTransactionEdits { get; set; }
        public virtual ICollection<LgTransaction> LgTransactions { get; set; }
        public virtual ICollection<PriceListCustomer> PriceListCustomers { get; set; }
        public virtual ICollection<Rentform> Rentforms { get; set; }
        public virtual ICollection<Reservationitem> Reservationitems { get; set; }
        public virtual ICollection<ReservedUnit> ReservedUnits { get; set; }
        public virtual ICollection<Saleform> Saleforms { get; set; }
        public virtual ICollection<ServicesInstitem> ServicesInstitemCustStoreAllcodesIdnewNavigations { get; set; }
        public virtual ICollection<ServicesInstitem> ServicesInstitemMandatories { get; set; }
        public virtual ICollection<ServicesMetersReading> ServicesMetersReadings { get; set; }
        public virtual ICollection<SlidesStaff> SlidesStaffs { get; set; }
        public virtual ICollection<StoreAllcodesBegin> StoreAllcodesBegins { get; set; }
        public virtual ICollection<StoreCustDeposit> StoreCustDepositCusts { get; set; }
        public virtual ICollection<StoreCustDeposit> StoreCustDepositStores { get; set; }
        public virtual ICollection<StoreInventoryM> StoreInventoryMs { get; set; }
        public virtual ICollection<StoreItemsBal> StoreItemsBals { get; set; }
        public virtual ICollection<StoreSubCodeSpec> StoreSubCodeSpecs { get; set; }
        public virtual ICollection<StoreTrn> StoreTrnCashes { get; set; }
        public virtual ICollection<StoreTrn> StoreTrnFromStoreAllcodes { get; set; }
        public virtual ICollection<StoreTrn> StoreTrnToStoreAllcodes { get; set; }
        public virtual ICollection<StoreTrnsExpTemp> StoreTrnsExpTemps { get; set; }
        public virtual ICollection<StoreTrnsExp> StoreTrnsExps { get; set; }
        public virtual ICollection<StoreTrnsLc> StoreTrnsLcs { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMFromStoreAllcodes { get; set; }
        public virtual ICollection<StoreTrnsMTemp> StoreTrnsMTempFromStoreAllcodes { get; set; }
        public virtual ICollection<StoreTrnsMTemp> StoreTrnsMTempToStoreAllcodes { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMToStoreAllcodes { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMTypes { get; set; }
        public virtual ICollection<StoreTrnsO> StoreTrnsODsts { get; set; }
        public virtual ICollection<StoreTrnsO> StoreTrnsOInjures { get; set; }
        public virtual ICollection<StoreTrnsOTemp> StoreTrnsOTemps { get; set; }
        public virtual ICollection<StoreTrnsPrice> StoreTrnsPrices { get; set; }
        public virtual ICollection<Storeallcodesattachment> Storeallcodesattachments { get; set; }
        public virtual ICollection<Storeitemsallcode> Storeitemsallcodes { get; set; }
        public virtual ICollection<UsersStoreAllcode> UsersStoreAllcodes { get; set; }
    }
}
