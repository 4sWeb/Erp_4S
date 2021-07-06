using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreItemsRepo:Base_Repo<StoreItem>, IStoreItems
    {
        public StoreItemsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
