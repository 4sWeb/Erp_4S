using BLL.ERPModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrns:IBaseRepo<StoreTrn>
    {
        List<StoreTrans> AllTransactionInModul(List<Storespecapp> ListStoreSpecsApp,int PeriodID);
        TransactionSpecs_VM GetTransactionSpecsById(decimal id);
    } 
}
