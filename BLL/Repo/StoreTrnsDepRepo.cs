using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsDepRepo : Base_Repo<StoreTrnsDep>, IStoreTrnsDep
    {
        private readonly IRepoWrapper repo;
        public StoreTrnsDepRepo(ModelContext dbContext4S) : base(dbContext4S)
        {

        }
        //convert viewmodel to model and add it 
        public void convert_VMtoModel(StoreTransDep_VM StoreTransDep_VM)
        {
            StoreTrnsDep storeTrnsDep = new StoreTrnsDep() { Ptransrowid = StoreTransDep_VM.Ptransrowid, Groupid = StoreTransDep_VM.Groupid };
            repo._StoreTrnsDep.Create(storeTrnsDep);
        }

        //Retrive List of previousTransactionIds by id
        public List<decimal> RetriveListPrevTransIds(decimal storeTransMId)
        {
            List<decimal> ids = new List<decimal>();
            if (storeTransMId != default)
            {
                var result =GetByCondition(c => c.Ctrnsrowid == storeTransMId).Result.Select(c=>c.Ptransrowid);
                foreach (var item in result)
                {
                    ids.Add((decimal)item);
                }
                return ids;
                  
            }
                return null;
        }
    }
}
