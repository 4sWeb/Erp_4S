using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsMRepo : Base_Repo<StoreTrnsM>, IStoreTrnsM
    {
        public StoreTrnsMRepo(ModelContext dbContext4S) : base(dbContext4S)
        {

        }

        public int GetCountFromStoreTrnsM(decimal TrnsCode)
        {
            return GetByCondition(c => c.TrnsCode == TrnsCode).Result.Count;
        }

        public List<Transaction_VM> AllTransactionByIdAndPeriodId(decimal id, decimal PeriodId)
        {
            if (id != default)
            {
                return GetByCondition(s => s.TrnsCode == id && s.Period == PeriodId && s.Commited == 1).Result.Select(s => new Transaction_VM
                {
                    TrnsCode = s.TrnsCode,
                    TrnsNo = s.TrnsNo,
                    TrnsDate = s.TrnsDate,
                    Period = s.Period,
                    FromStoreAllcodesId = s.FromStoreAllcodesId,
                    ToStoreAllcodesId = s.ToStoreAllcodesId,
                    StoreTrnsMId = s.StoreTrnsMId,
                    BranchId = s.BranchId,
                    Storedocnum = s.Storedocnum
                }).ToList();
            }
            return null;
        }
    }
}
