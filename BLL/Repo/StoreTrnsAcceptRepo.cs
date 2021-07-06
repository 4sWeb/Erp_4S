using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
   public  class StoreTrnsAcceptRepo:Base_Repo<StoreTrnsAccept>, IStoreTrnsAccept
    {
        public StoreTrnsAcceptRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
