using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoredsttypesRepo:Base_Repo<Storedsttype>, IStoredsttypes
    {
        public StoredsttypesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
