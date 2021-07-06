using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsORepo:Base_Repo<StoreTrnsO>, IStoreTrnsO
    {
        public StoreTrnsORepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
