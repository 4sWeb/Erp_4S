using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreItemUnitsRepo:Base_Repo<StoreItemUnit>, IStoreItemUnits
    {
        public StoreItemUnitsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
