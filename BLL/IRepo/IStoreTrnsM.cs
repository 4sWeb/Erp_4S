using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrnsM:IBaseRepo<StoreTrnsM>
    {
        int GetCountFromStoreTrnsM(decimal TrnsCode);
        List<Transaction_VM> AllTransactionByIdAndPeriodId(decimal id , decimal PeriodId);
    }
}
