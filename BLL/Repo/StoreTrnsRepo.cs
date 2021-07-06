using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsRepo:Base_Repo<StoreTrn>, IStoreTrns
    {
        public StoreTrnsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
