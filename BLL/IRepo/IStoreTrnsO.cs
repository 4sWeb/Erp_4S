using BLL.ERPModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrnsO:IBaseRepo<StoreTrnsO>
    {
        public List<StoreTransDetails_VM> GetTransactionsDetailsList(List<decimal> TransactionsList,decimal Getitems);
        public void convert_VMtoModel(List<StoreTransDetails_VM> StoreTransMain_VM);
         List<StoreTransDetails_VM> RetriveDetailsTransactionById(decimal storeTransMId);
        public List<StoreTransDetails_VM> CalculatePriceForDepDetailsProduct(List<StoreTransDetails_VM> storeTransDetails_VMs, decimal DepPricetype);
    }
}
