using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepo
{
    public interface IRepoWrapper
    {
        IAcceptInTrns _AcceptInTrns { get; }
        IAccountstree _AccountsTree { get; }
        IAgriage _Agriage { get; }
        IAgridata _Agridata { get; }
        IAgrifarm _Agrifarm { get; }
        IAgriprocess _Agriprocess { get; }
        IBoatport _Boatport { get; }
        IConditionsbooklet _Conditionsbooklet { get; }
        ICurrencym _Currencym { get; }
        ICurrencyo _Currencyo { get; }
        IDimensionlevels _Dimensionlevels { get; }
        IDimensions _Dimensions { get; }
        IDimensionsdetails _Dimensionsdetails { get; }
        IDiscountItemM _DiscountItemM { get; }
        IDiscountListType _DiscountListType { get; }
        IFinancepuposes _Financepuposes { get; }
        IFinancespec _Financespec { get; }
        IFinancetype _Financetype { get; }
        IGroupBasicData _GroupBasicData { get; }
        IGroupf _Groupf { get; }
        IInstprograms _Instprograms { get; }
        IIstransfer _Istransfer { get; }
        IMainTypes _MainTypes { get; }
        IPeriod _Period { get; }
        IPreferences _Preferences { get; }
        IProducationformla _Producationformla { get; }
        IProductformladetails _Productformladetails { get; }
        IProductstages _Productstages { get; }
        IShippingcotypes _Shippingcotypes { get; }
        IStaff _Staff { get; }
        IStages _Stages { get; }
        IStoreAllcodes _StoreAllcodes { get; }
        IStoreAllcodesBegin _StoreAllcodesBegin { get; }
        IStoreAllsubcodes _StoreAllsubcodes { get; }
        IStoreDepSpecs _StoreDepSpecs { get; }
        IStoreDepSpecsDetails _StoreDepSpecsDetails { get; }
        IStoredsttypes _Storedsttypes { get; }
        IStoreItemformsSpecs _StoreItemformsSpecs { get; }
        IStoreItems _StoreItems { get; }
        IStoreItemUnits _StoreItemUnits { get; }
        IStoreSubCodeSpec _StoreSubCodeSpec { get; }
        IStoreTrns _StoreTrns { get; }
        IStoreTrnsAccept _StoreTrnsAccept { get; }
        IStoreTrnsDep _StoreTrnsDep { get; }
        IStoreTrnsDepDetails _StoreTrnsDepDetails { get; }
        IStoreTrnsM _StoreTrnsM { get; }
        IStoreTrnsO _StoreTrnsO { get; }
        IStoreTrnsoDimensionsdetails _StoreTrnsoDimensionsdetails { get; }
        IStoreTrnsProducationformla _StoreTrnsProducationformla { get; }
        IStoreUnits _StoreUnits { get; }
        IUserapps _Userapps { get; }
        IUsergroup _Usergroup { get; }
        IUserperiod _Userperiod { get; }
        IUsers _Users { get; }
        IUserstrans _Userstrans { get; }
        IStorespecapp _Storepecsapp { get; }
        IBranch _branch { get; }
        IPaymenttype _Paymenttype { get; }
        IInstprogram _Instprogram { get; }
        IStoretrnsmpayspec _Storetrnsmpayspec { get; }
        IStoretrnsextra _Storetrnsextra { get; }
        IExtra _Extra { get; }
        IStoremextra _Storemextra { get; }
        ICommittee _Committee { get; }
        ICommitteedetail _Committeedetail { get; }
        Task<List<object>> CallQuery(string query, Dictionary<string, object> para = null, int type = 0);
        void Save();
    }
}
