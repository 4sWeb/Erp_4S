using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreSubCodeSpecRepo:Base_Repo<StoreSubCodeSpec>, IStoreSubCodeSpec
    {
        public StoreSubCodeSpecRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
