using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoredsttypesRepo:Base_Repo<Storedsttype>, IStoredsttypes
    {
        public StoredsttypesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }

        public List<Storedsttype> ListStoreDstTypeByTransID(decimal id, string type)
        {
            if (id != default)
                return GetByCondition(s => s.Trnscode == id && s.Ft == type).Result;
            return null;
        }
    }
}
