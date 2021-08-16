using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
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
    }
}
