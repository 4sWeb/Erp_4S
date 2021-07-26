using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoreAllsubcodesRepo:Base_Repo<StoreAllsubcode>, IStoreAllsubcodes
    {
        public StoreAllsubcodesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
  
        public StoreAllsubcode GetStoreAllSubCodeByID(decimal? Id)
        {
            if (Id != default && Id != null)
                return GetByCondition(s => s.StoreAllsubcodesId == Id).Result.FirstOrDefault();
            return null;
        }

    }
}
