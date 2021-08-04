using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrnsO:IBaseRepo<StoreTrnsO>
    {
        public List<TransactionsDetails_VM> GetTransactionsDetailsList(List<decimal> TransactionsList);
    }
}
