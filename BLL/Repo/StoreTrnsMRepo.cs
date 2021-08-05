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
        private ModelContext _dbContext4S;
        private TestQuery test = new TestQuery();

        public StoreTrnsMRepo(ModelContext dbContext4S) : base(dbContext4S)
        {
            _dbContext4S = dbContext4S;
        }

        public int GetCountFromStoreTrnsM(decimal TrnsCode, int PeriodID)
        {
            return GetByCondition(c => c.TrnsCode == TrnsCode && c.Commited == 1 && c.Period == PeriodID).Result.Count;
        }

        public List<Transaction_VM> AllTransactionByIdAndPeriodId(decimal id, decimal PeriodId)
        {
            if (id != default)
            {
                storeAllsubcodesRepo = new StoreAllsubcodesRepo(_dbContext4S);
                storeAllcodesRepo = new StoreAllcodesRepo(_dbContext4S);
                mainTypesRepo = new MainTypesRepo(_dbContext4S);

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

        public List<Transaction_VM> AllTransByDepID(decimal DepID)
        {
            storeAllsubcodesRepo = new StoreAllsubcodesRepo(_dbContext4S);
            storeAllcodesRepo = new StoreAllcodesRepo(_dbContext4S);
            mainTypesRepo = new MainTypesRepo(_dbContext4S);
            List<Transaction_VM> Items = new List<Transaction_VM>();
            if (DepID != default)
            {
                Dictionary<string, object> par = new Dictionary<string, object>();
                par.Add("@DepDetID", null);
                par.Add("@TRANSCODE", DepID);
                var TransList = test.Get("GetdepremaningqtyAllTrans2", par, 1);
                foreach (var item in TransList.Result.ToList())
                {
                    Dictionary<string, object> Current = (Dictionary<string, object>)item;
                    var NewItem = GetByCondition(c => c.StoreTrnsMId == decimal.Parse(Current.GetValueOrDefault("MID").ToString())).Result.Select(s => new { s.TrnsCode, s.TrnsDate, s.TrnsNo, s.StoreTrnsMId, s.FromStoreAllcodesId, s.ToStoreAllcodesId, s.BranchId, s.Storedocnum, s.Period });
                    Items.Add(new Transaction_VM
                    {
                        StoreTrnsMId = NewItem.FirstOrDefault().StoreTrnsMId,
                        TrnsCode = NewItem.FirstOrDefault().TrnsCode,
                        TrnsDate = NewItem.FirstOrDefault().TrnsDate,
                        From_TypeName = mainTypesRepo.GetNameFromMAinType(NewItem.FirstOrDefault().FromStoreAllcodesId),
                        From_StoreAllcodesId = NewItem.FirstOrDefault().FromStoreAllcodesId,
                        From_StoreAllcodesName = storeAllcodesRepo.GetStoreAllCodeById(NewItem.FirstOrDefault().FromStoreAllcodesId) != null ? storeAllcodesRepo.GetStoreAllCodeById(NewItem.FirstOrDefault().FromStoreAllcodesId).Aname : null,
                        TO_TypeName = mainTypesRepo.GetNameFromMAinType(NewItem.FirstOrDefault().ToStoreAllcodesId),
                        To_StoreAllcodesId = NewItem.FirstOrDefault().ToStoreAllcodesId,
                        To_StoreAllcodesName = storeAllcodesRepo.GetStoreAllCodeById(NewItem.FirstOrDefault().ToStoreAllcodesId) != null ? storeAllcodesRepo.GetStoreAllCodeById(NewItem.FirstOrDefault().ToStoreAllcodesId).Aname : null,
                        BranchId = NewItem.FirstOrDefault().BranchId,
                        branch = storeAllsubcodesRepo.GetStoreAllSubCodeByID(NewItem.FirstOrDefault().BranchId) != null ? storeAllsubcodesRepo.GetStoreAllSubCodeByID(NewItem.FirstOrDefault().BranchId).Aname : null,
                        Storedocnum = NewItem.FirstOrDefault().Storedocnum,
                        Period = NewItem.FirstOrDefault().Period,
                        TrnsNo = NewItem.FirstOrDefault().TrnsNo
                    });
                }
            }
            return Items;
        }


        public object GetMaxID(decimal TransCode, decimal PeriodID, decimal BranchID)
        {
            return GetByCondition(c => c.BranchId == BranchID && c.TrnsCode == TransCode && c.Period == PeriodID).Result.LastOrDefault().TrnsNo + 1;
        }
    }
}
