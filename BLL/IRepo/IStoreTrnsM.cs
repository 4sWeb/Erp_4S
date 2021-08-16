using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrnsM:IBaseRepo<StoreTrnsM>
    {
        int GetCountFromStoreTrnsM(decimal TrnsCode, int PeriodID);
        List<Transaction_VM> AllTransactionByIdAndPeriodId(decimal id , decimal PeriodId);
        List<Transaction_VM> AllTransByDepID(decimal DepID);
        object GetMaxID(decimal TransCode, decimal PeriodID, decimal BranchID);
        public void convert_VMtoModel(StoreTransMaster_VM StM_VM) { }
    }
  
}
