using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.IRepo;
using DAL.Models;
namespace BLL.Repo
{
    public class RepoWrapper : IRepoWrapper
    {
        private ModelContext _contex;
        private IAcceptInTrns acceptInTrns;
        private IAccountstree accountstree;
        private IAgriage agriage;
        private IAgridata agridata;
        private IAgrifarm  agrifarm;
        private IAgriprocess agriprocess;
        private IBoatport boatport;
        private IConditionsbooklet conditionsbooklet;
        private ICurrencym currencym;
        private ICurrencyo currencyo;
        private IDimensionlevels dimensionlevels;
        private IDimensions dimensions;
        private IDimensionsdetails dimensionsdetails;
        private IDiscountItemM discountItemM;
        private IDiscountListType discountListType;
        private IFinancepuposes financepuposes;
        private IFinancespec financespec;
        private IFinancetype  financetype;
        private IGroupBasicData  groupBasicData;
        private IGroupf groupf;
        private IInstprograms instprograms;
        private IIstransfer istransfer;
        private IMainTypes mainTypes;
        private IPeriod period;
        private IPreferences  preferences;
        private IProducationformla producationformla;
        private IProductformladetails  productformladetails;
        private IProductstages productstages;
        private IShippingcotypes  shippingcotypes;
        private IStaff staff;
        private IStages stages;
        private IStoreAllcodes storeAllcodes;
        private IStoreAllcodesBegin  storeAllcodesBegin;
        private IStoreAllsubcodes storeAllsubcodes;
        private IStoreDepSpecs storeDepSpecs;
        private IStoreDepSpecsDetails  storeDepSpecsDetails;
        private IStoredsttypes storedsttypes;
        private IStoreItemformsSpecs storeItemformsSpecs;
        private IStoreItems storeItems;
        private IStoreItemUnits storeItemUnits;
        private IStoreSubCodeSpec storeSubCodeSpec;
        private IStoreTrns storeTrns;
        private IStoreTrnsAccept  storeTrnsAccept;
        private IStoreTrnsDep storeTrnsDep;
        private IStoreTrnsDepDetails  storeTrnsDepDetails;
        private IStoreTrnsM  storeTrnsM;
        private IStoreTrnsO storeTrnsO;
        private IStoreTrnsoDimensionsdetails storeTrnsoDimensionsdetails;
        private IStoreTrnsProducationformla  storeTrnsProducationformla;
        private IStoreUnits  storeUnits;
        private IUserapps  userapps;
        private IUsergroup usergroup;
        private IUserperiod  userperiod;
        private IUsers users;
        private IUserstrans  userstrans;
        private IStorespecapp storepecsapp;
        private IBranch branch;
        private IPaymenttype paymenttype;
        private IInstprogram instprogram;
        private IStoretrnsmpayspec storetrnsmpayspec;
        private IStoretrnsextra storetrnsextra;
        private IExtra extra;
        private IStoremextra storemextra;
        private ICommittee committee;
        private ICommitteedetail committeedetail;


        public RepoWrapper(ModelContext context)
        {
            _contex = context;
        }
        public IAcceptInTrns _AcceptInTrns
        {
           get 
           {
            if(acceptInTrns==null) acceptInTrns =new AcceptInTrnsRepo(_contex); return acceptInTrns;
           }
        }
        public IAccountstree _AccountsTree { get { if (accountstree == null) accountstree = new AccountstreeRepo(_contex);return accountstree; } }
        public IAgriage _Agriage { get { if (agriage == null) agriage = new AgriageRepo(_contex); return agriage; } }
        public IAgridata _Agridata { get { if (agridata == null) agridata = new AgridataRepo(_contex); return agridata; } }
        public IAgrifarm _Agrifarm { get { if (agrifarm == null) agrifarm = new AgrifarmRepo(_contex); return agrifarm; } }
        public IAgriprocess _Agriprocess { get { if (agriprocess == null) agriprocess = new AgriprocessRepo(_contex); return agriprocess; } }
        public IBoatport _Boatport { get { if (boatport == null) boatport = new BoatportRepo(_contex); return boatport; } }
        public IConditionsbooklet _Conditionsbooklet { get { if (conditionsbooklet == null) conditionsbooklet = new ConditionsbookletRepo (_contex); return conditionsbooklet ; } }
        public ICurrencym _Currencym { get { if (currencym == null) currencym = new CurrencymRepo(_contex); return currencym; } }
        public ICurrencyo _Currencyo { get { if (currencyo == null) currencyo = new CurrencyoRepo(_contex); return currencyo; } }
        public IDimensionlevels _Dimensionlevels { get { if (dimensionlevels == null) dimensionlevels = new DimensionlevelsRepo(_contex); return dimensionlevels; } }
        public IDimensions _Dimensions { get { if (dimensions == null) dimensions = new DimensionsRepo(_contex); return dimensions; } }
        public IDimensionsdetails _Dimensionsdetails { get { if (dimensionsdetails == null) dimensionsdetails = new DimensionsdetailsRepo(_contex); return dimensionsdetails; } }
        public IDiscountItemM _DiscountItemM { get { if (discountItemM == null) discountItemM = new DiscountItemMRepo(_contex); return discountItemM; } }
        public IDiscountListType _DiscountListType { get { if (discountListType == null) discountListType = new DiscountListTypeRepo(_contex); return discountListType; } }
        public IFinancepuposes _Financepuposes { get { if (financepuposes == null) financepuposes = new FinancepuposesRepo(_contex); return financepuposes; } }
        public IFinancespec  _Financespec { get { if (financespec == null) financespec = new FinancespecRepo (_contex); return financespec; } }
        public IFinancetype _Financetype { get { if (financetype== null) financetype = new FinancetypeRepo (_contex); return financetype; } }
        public IGroupBasicData  _GroupBasicData { get { if (groupBasicData == null) groupBasicData = new GroupBasicDataRepo(_contex); return groupBasicData; } }
        public IGroupf  _Groupf { get { if (groupf == null) groupf = new GroupfRepo(_contex); return groupf; } }
        public IInstprograms _Instprograms { get { if (instprograms == null) instprograms = new InstprogramsRepo(_contex); return instprograms; } }
        public IIstransfer  _Istransfer { get { if (istransfer == null) istransfer = new IstransferRepo(_contex); return istransfer; } }
        public IMainTypes  _MainTypes { get { if (mainTypes == null) mainTypes = new MainTypesRepo (_contex); return mainTypes; } }
        public IPeriod  _Period { get { if (period == null) period = new PeriodRepo (_contex); return period; } }
        public IPreferences  _Preferences { get { if (preferences == null) preferences = new PreferencesRepo(_contex); return preferences; } }
        public IProducationformla _Producationformla { get { if (producationformla == null) producationformla = new ProducationformlaRepo(_contex); return producationformla; } }
        public IProductformladetails _Productformladetails { get { if (productformladetails == null) productformladetails = new ProductformladetailsRepo(_contex); return productformladetails; } }
        public IProductstages _Productstages { get { if (productstages == null) productstages = new ProductstagesRepo(_contex); return productstages; } }
        public IShippingcotypes _Shippingcotypes { get { if (shippingcotypes == null) shippingcotypes = new ShippingcotypesRepo(_contex); return shippingcotypes; } }
        public IStaff _Staff { get { if (staff == null) staff = new StaffRepo(_contex); return staff; } }
        public IStages _Stages { get { if (stages == null) stages = new StagesRepo(_contex); return stages; } }
        public IStoreAllcodes _StoreAllcodes { get { if (storeAllcodes == null) storeAllcodes = new StoreAllcodesRepo(_contex); return storeAllcodes; } }
        public IStoreAllcodesBegin  _StoreAllcodesBegin { get { if (storeAllcodesBegin == null) storeAllcodesBegin = new StoreAllcodesBeginRepo(_contex); return storeAllcodesBegin; } }
        public IStoreAllsubcodes _StoreAllsubcodes { get { if (storeAllsubcodes == null) storeAllsubcodes = new StoreAllsubcodesRepo(_contex); return storeAllsubcodes; } }
        public IStoreDepSpecs _StoreDepSpecs { get { if (storeDepSpecs == null) storeDepSpecs = new StoreDepSpecsRepo(_contex); return storeDepSpecs; } }
        public IStoreDepSpecsDetails _StoreDepSpecsDetails { get { if (storeDepSpecsDetails == null) storeDepSpecsDetails = new StoreDepSpecsDetailsRepo (_contex); return storeDepSpecsDetails; } }
        public IStoredsttypes _Storedsttypes { get { if (storedsttypes == null) storedsttypes = new StoredsttypesRepo(_contex); return storedsttypes; } }
        public IStoreItemformsSpecs _StoreItemformsSpecs { get { if (storeItemformsSpecs == null) storeItemformsSpecs = new StoreItemformsSpecsRepo(_contex); return storeItemformsSpecs; } }
        public IStoreItems _StoreItems { get { if (storeItems == null) storeItems = new StoreItemsRepo(_contex); return storeItems; } }
        public IStoreItemUnits _StoreItemUnits  { get { if (storeItemUnits == null) storeItemUnits = new StoreItemUnitsRepo(_contex); return storeItemUnits; } }
        public IStoreSubCodeSpec _StoreSubCodeSpec { get { if (storeSubCodeSpec == null) storeSubCodeSpec = new StoreSubCodeSpecRepo(_contex); return storeSubCodeSpec; } }
        public IStoreTrns  _StoreTrns { get { if (storeTrns == null) storeTrns = new StoreTrnsRepo(_contex); return storeTrns; } }
        public IStoreTrnsAccept  _StoreTrnsAccept  { get { if (storeTrnsAccept == null) storeTrnsAccept = new StoreTrnsAcceptRepo(_contex); return storeTrnsAccept; } }
        public IStoreTrnsDep  _StoreTrnsDep { get { if (storeTrnsDep == null) storeTrnsDep = new StoreTrnsDepRepo (_contex); return storeTrnsDep; } }
        public IStoreTrnsDepDetails _StoreTrnsDepDetails  { get { if (storeTrnsDepDetails == null) storeTrnsDepDetails = new StoreTrnsDepDetailsRepo (_contex); return storeTrnsDepDetails; } }
        public IStoreTrnsM  _StoreTrnsM { get { if (storeTrnsM == null) storeTrnsM = new StoreTrnsMRepo(_contex); return storeTrnsM; } }
        public IStoreTrnsO  _StoreTrnsO  { get { if (storeTrnsO == null) storeTrnsO = new StoreTrnsORepo(_contex); return storeTrnsO; } }
        public IStoreTrnsoDimensionsdetails  _StoreTrnsoDimensionsdetails { get { if (storeTrnsoDimensionsdetails == null) storeTrnsoDimensionsdetails = new StoreTrnsoDimensionsdetailsRepo (_contex); return storeTrnsoDimensionsdetails; } }
        public IStoreTrnsProducationformla  _StoreTrnsProducationformla { get { if (storeTrnsProducationformla == null) storeTrnsProducationformla = new StoreTrnsProducationformlaRepo(_contex); return storeTrnsProducationformla; } }
        public IStoreUnits  _StoreUnits  { get { if (storeUnits == null) storeUnits = new StoreUnitsRepo(_contex); return storeUnits; } }
        public IUserapps  _Userapps  { get { if (userapps == null) userapps = new UserappsRepo(_contex); return userapps; } }
        public IUsergroup _Usergroup  { get { if (usergroup == null) usergroup = new UsergroupRepo(_contex); return usergroup; } }
        public IUserperiod  _Userperiod  { get { if (userperiod == null) userperiod = new UserperiodRepo(_contex); return userperiod; } }
        public IUsers _Users { get { if (users == null) users = new UsersRepo (_contex); return users; } }
        public IUserstrans  _Userstrans { get { if (userstrans == null) userstrans = new UserstransRepo(_contex); return userstrans; } }
        public IStorespecapp _Storepecsapp { get { if (storepecsapp == null) storepecsapp = new StorespecappRepo(_contex); return storepecsapp; } }
        public IBranch _branch { get { if (branch == null) branch = new BranchRepo(_contex); return branch; } }
        public IPaymenttype _Paymenttype { get { if (paymenttype == null) paymenttype = new PaymenttypeRepo(_contex); return paymenttype; } }
        public IInstprogram _Instprogram { get { if (instprogram == null) instprogram = new InstprogramRepo(_contex); return instprogram; } }
        public IStoretrnsmpayspec _Storetrnsmpayspec { get { if (storetrnsmpayspec == null) storetrnsmpayspec = new StoretrnsmpayspecRepo(_contex); return storetrnsmpayspec; } }
        public IStoretrnsextra _Storetrnsextra { get { if (storetrnsextra == null) storetrnsextra = new StoretrnsextraRepo(_contex); return storetrnsextra; } }
        public IExtra _Extra { get { if (extra == null) extra = new ExtraRepo(_contex); return extra; } }
        public IStoremextra _Storemextra { get { if (storemextra == null) storemextra = new StoremextraRepo(_contex); return storemextra; } }
        public ICommittee _Committee { get { if (committee == null) committee = new CommitteeRepo(_contex); return committee; } }
        public ICommitteedetail _Committeedetail { get { if (committeedetail == null) committeedetail = new CommitteedetailRepo(_contex); return committeedetail; } }
       
        public async Task<List<object>> CallQuery(string query, Dictionary<string, object> para = null, int type = 0)
        {
            TestQuery queryengine = new TestQuery();
            var result = await queryengine.Get(query, para, type);
            return result;
        }

        public void Save()
        {
            _contex.SaveChanges();
        }
    }
}
