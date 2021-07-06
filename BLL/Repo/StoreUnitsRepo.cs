using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreUnitsRepo:Base_Repo<StoreUnit>, IStoreUnits
    {
        public StoreUnitsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
