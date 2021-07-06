using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreItemformsSpecsRepo:Base_Repo<StoreItemformsSpec>, IStoreItemformsSpecs
    {
        public StoreItemformsSpecsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
