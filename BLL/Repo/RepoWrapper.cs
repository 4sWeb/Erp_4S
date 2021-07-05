using System;
using System.Collections.Generic;
using System.Text;
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
        public void Save()
        {
            _contex.SaveChanges();
        }
    }
}
