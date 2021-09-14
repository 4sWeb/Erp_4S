using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrnsO:IBaseRepo<StoreTrnsO>
    {
        public List<StoreTransDetails_VM> GetTransactionsDetailsList(List<decimal> TransactionsList);
        public void convert_VMtoModel(List<StoreTransDetails_VM> StoreTransMain_VM);
         List<StoreTransDetails_VM> RetriveDetailsTransactionById(decimal storeTransMId);
    }
}
