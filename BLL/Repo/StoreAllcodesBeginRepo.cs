using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreAllcodesBeginRepo:Base_Repo<StoreAllcodesBegin>, IStoreAllcodesBegin
    {
        public StoreAllcodesBeginRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
