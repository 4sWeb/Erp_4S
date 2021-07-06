using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsDepRepo:Base_Repo<StoreTrnsDep>, IStoreTrnsDep
    {
        public StoreTrnsDepRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
