using System;
using System.Collections.Generic;
using System.Text;

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
         ICurrencym  _Currencym { get; }
         ICurrencyo _Currencyo { get; }
         IDimensionlevels _Dimensionlevels { get; }
         IDimensions _Dimensions { get; }
         IDimensionsdetails _Dimensionsdetails { get; }
         IDiscountItemM _DiscountItemM { get; }
         IDiscountListType _DiscountListType { get; }
         IFinancepuposes _Financepuposes { get; }
         IFinancespec _Financespec { get; }
         IFinancetype  _Financetype { get; }
         IGroupBasicData  _GroupBasicData { get; }
         IGroupf _Groupf { get; }
         IInstprograms _Instprograms { get; }
        void Save();
    }
}
