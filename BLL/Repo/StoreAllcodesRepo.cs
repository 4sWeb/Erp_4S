using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreAllcodesRepo:Base_Repo<StoreAllcode>, IStoreAllcodes
    {
        public StoreAllcodesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
