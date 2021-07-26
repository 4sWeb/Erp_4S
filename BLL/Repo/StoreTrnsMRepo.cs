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
        private StoreAllsubcodesRepo storeAllsubcodesRepo;
        private StoreAllcodesRepo storeAllcodesRepo;
        private MainTypesRepo mainTypesRepo;

        public StoreTrnsMRepo(ModelContext dbContext4S) : base(dbContext4S)
        {
            storeAllsubcodesRepo = new StoreAllsubcodesRepo(dbContext4S);
            storeAllcodesRepo = new StoreAllcodesRepo(dbContext4S);
            mainTypesRepo = new MainTypesRepo(dbContext4S);

        }

        public int GetCountFromStoreTrnsM(decimal TrnsCode, int PeriodID)
        {
            return GetByCondition(c => c.TrnsCode == TrnsCode && c.Commited == 1 && c.Period == PeriodID).Result.Count;
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
                    From_TypeName = mainTypesRepo.GetNameFromMAinType(s.FromStoreAllcodesId),
                    From_StoreAllcodesId = s.FromStoreAllcodesId,
                    From_StoreAllcodesName = storeAllcodesRepo.GetStoreAllCodeById(s.FromStoreAllcodesId) != null ? storeAllcodesRepo.GetStoreAllCodeById(s.FromStoreAllcodesId).Aname : null,
                    TO_TypeName = mainTypesRepo.GetNameFromMAinType(s.ToStoreAllcodesId),
                    To_StoreAllcodesId = s.ToStoreAllcodesId,
                    To_StoreAllcodesName = storeAllcodesRepo.GetStoreAllCodeById(s.ToStoreAllcodesId) != null ? storeAllcodesRepo.GetStoreAllCodeById(s.ToStoreAllcodesId).Aname : null,
                    StoreTrnsMId = s.StoreTrnsMId,
                    BranchId = s.BranchId,
                    branch = storeAllsubcodesRepo.GetStoreAllSubCodeByID(s.BranchId) != null ? storeAllsubcodesRepo.GetStoreAllSubCodeByID(s.BranchId).Aname : null,
                    Storedocnum = s.Storedocnum
                }).ToList();
            }
            return null;
        }
    }
}
