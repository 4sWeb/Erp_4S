using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoreDepSpecsRepo:Base_Repo<StoreDepSpec>, IStoreDepSpecs
    {
        public StoreDepSpecsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }

        public List<StoreDepSpec> GetAllStoreDepSpecById(decimal id)
        {
            if (id != default)
            {
                var StoreDepSpecList = GetByCondition(s => s.Trnscode == id).Result;
                return StoreDepSpecList.Count > 0 ? StoreDepSpecList : null;
            }
            return null;
        }
    }
}
