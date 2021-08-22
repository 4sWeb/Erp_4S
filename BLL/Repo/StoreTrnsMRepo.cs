﻿using BLL.IRepo;
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
        private readonly IRepoWrapper repo;
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

        //convert viewmodel to model and add it 
        public void convert_VMtoModel(StoreTransMaster_VM StM_VM)
        {
            //var branch = StM_VM.Branches.FirstOrDefault();
            //var toCodeId = StM_VM.ToTypeDetails.FirstOrDefault();
            //var fromCodeId = StM_VM.From_Type.FirstOrDefault();

            //Dictionary<string, object> currently = (Dictionary<string, object>)branch;
            //branch = int.Parse(currently.FirstOrDefault().Value.ToString());

            //Dictionary<string, object> current = (Dictionary<string, object>)fromCodeId;
            //fromCodeId = int.Parse(current.FirstOrDefault().Value.ToString());

            //Dictionary<string, object> currentt = (Dictionary<string, object>)toCodeId;
            //toCodeId = int.Parse(currentt.FirstOrDefault().Value.ToString());
            StoreTrnsM StoreTrnsM = new StoreTrnsM() { TrnsCode = StM_VM.TrnsCode, Rem = StM_VM.Rem, TrnsNo = StM_VM.TrnsNo, BranchId = StM_VM.BranchId, TrnsDate = StM_VM.TrnsDate, Storedocnum = StM_VM.Storedocnum, FromStoreAllcodesId = StM_VM.FromStoreAllcodesId, ToStoreAllcodesId = StM_VM.ToStoreAllcodesId, Period = StM_VM.Period, StoreTrnsMId = StM_VM.StoreTrnsMId };
            repo._StoreTrnsM.Create(StoreTrnsM);
        }


        //Retrive Tranaction master by id
        public StoreTransMaster_VM RetriveMasterTransactionById( decimal storeTransMId)
        {
            if (storeTransMId != default)
            {
                var result= GetByCondition(c => c.StoreTrnsMId == storeTransMId).Result.Select(s => new StoreTransMaster_VM
                {
                    TrnsDate = s.TrnsDate,
                    Rem=s.Rem,
                    ToStoreAllcodesId= (decimal)s.ToStoreAllcodesId,
                    FromStoreAllcodesId= (decimal)s.FromStoreAllcodesId,
                }
                ).FirstOrDefault() ;
                return (StoreTransMaster_VM)result;

            }
                return null;
        }


        //Retrive Tranaction Dep master by id
        public List<StoreTransDep_VM> RetriveTransaDepById(List<decimal> PTransRowIds)
        {
           
            List<StoreTransDep_VM> ListItem = new List<StoreTransDep_VM>();
            if (PTransRowIds != null)
            {
                foreach(var item in PTransRowIds)
                {
                   var  oneItem= GetByCondition(c => c.StoreTrnsMId == item).Result.Select(s => new StoreTransDep_VM
                    {
                        TrnsDate= s.TrnsDate,
                         Rem=s.Rem,
                        ToStoreAllcodesId= (decimal)s.ToStoreAllcodesId,
                        FromStoreAllcodesId= 0
                    }
                   ).FirstOrDefault();
                    ListItem.Add(oneItem);
                }
               
                return ListItem;
            }
            return null;
        }
    }

}
