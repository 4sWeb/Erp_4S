using AutoMapper;
using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsRepo : Base_Repo<StoreTrn>, IStoreTrns
    {
        private StoreTrnsMRepo storeTrnsMRepo;
        private StoreDepSpecsRepo storeDepSpecsRepo;
        private ModelContext _dbContext4S;

        public StoreTrnsRepo(ModelContext dbContext4S) : base(dbContext4S)
        {
            _dbContext4S = dbContext4S;
        }

        public List<StoreTrans> AllTransactionInModul(List<Storespecapp> ListStoreSpecsApp, int PeriodID)
        {
            storeTrnsMRepo = new StoreTrnsMRepo(_dbContext4S);

            List<StoreTrans> storetrnslst = new List<StoreTrans>();
            var ListStoreTrns = GetAll().Result.Select(s => new { s.TrnsCode, s.Aname, s.Ename }).ToList().OrderBy(c => c.TrnsCode).ToList();

            foreach (var item in ListStoreTrns.ToList())
            {
                var Checked = ListStoreSpecsApp.FirstOrDefault(s => s.Storespecid == item.TrnsCode);
                if (Checked == null)
                    ListStoreTrns.Remove(item);
                else
                {
                    var _orderscount = storeTrnsMRepo.GetCountFromStoreTrnsM(item.TrnsCode, PeriodID);
                    storetrnslst.Add(new StoreTrans { TransId = item.TrnsCode, AName = item.Aname, EName = item.Ename, Count = _orderscount });
                }
            }
            return storetrnslst;
        }

        public TransactionSpecs_VM GetTransactionSpecsById(decimal id)
        {
            if (id != default)
            {
                storeDepSpecsRepo = new StoreDepSpecsRepo(_dbContext4S);

                AutoMapperGeneric<StoreTrn, TransactionSpecs_VM> autoMapperGeneric = new AutoMapperGeneric<StoreTrn, TransactionSpecs_VM>();
                var TrnsObj = GetByCondition(s => s.TrnsCode == id).Result.FirstOrDefault();
                if (TrnsObj != null)
                {
                    TransactionSpecs_VM TransSpecVM_List = autoMapperGeneric.GetOneObject(TrnsObj);
                    var StoreDepSpecList = storeDepSpecsRepo.GetAllStoreDepSpecById(TransSpecVM_List.TrnsCode);
                    if (StoreDepSpecList != null)
                        foreach (var item in StoreDepSpecList)
                        {
                            TransactionsNames_VM transactionsNames_VM = new TransactionsNames_VM()
                            {
                                StoreDepSpec_Id = item.StoreDepSpecsId,
                                Transaction_Id = item.Trnscode,
                                Transaction_Name = item.Aname
                            };
                            TransSpecVM_List.TransactionsNames.Add(transactionsNames_VM);
                        }
                    return TransSpecVM_List;
                }
            }
            return null;
        }
    
    }
}
