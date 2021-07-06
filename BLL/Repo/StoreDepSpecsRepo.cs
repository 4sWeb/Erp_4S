using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreDepSpecsRepo:Base_Repo<StoreDepSpec>, IStoreDepSpecs
    {
        public StoreDepSpecsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
