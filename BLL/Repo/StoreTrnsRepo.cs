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
        StoreTrnsMRepo storeTrnsMRepo;

        public StoreTrnsRepo(ModelContext dbContext4S) : base(dbContext4S)
        {
            storeTrnsMRepo = new StoreTrnsMRepo(dbContext4S);
        }

        public List<StoreTrans> AllTransactionInModul(List<Storespecapp> ListStoreSpecsApp)
        {
            List<StoreTrans> storetrnslst = new List<StoreTrans>();
            var ListStoreTrns = GetAll().Result.Select(s => new { s.TrnsCode, s.Aname, s.Ename }).ToList().OrderBy(c => c.TrnsCode).ToList();

            foreach (var item in ListStoreTrns.ToList())
            {
                var Checked = ListStoreSpecsApp.FirstOrDefault(s => s.Storespecid == item.TrnsCode);
                if (Checked == null)
                    ListStoreTrns.Remove(item);
                else
                {
                    var _orderscount = storeTrnsMRepo.GetCountFromStoreTrnsM(item.TrnsCode);
                    storetrnslst.Add(new StoreTrans { TransId = item.TrnsCode, AName = item.Aname, EName = item.Ename, Count = _orderscount });
                }
            }
            return storetrnslst;
        }

        public StoreTrn GetTransactionSpecsById(decimal id)
        {
            if (id != default)
                return GetByCondition(s => s.TrnsCode == id).Result.FirstOrDefault();
            return null;
        }
    }
}
