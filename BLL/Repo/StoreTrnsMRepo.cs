using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsMRepo:Base_Repo<StoreTrnsM>, IStoreTrnsM
    {
        public StoreTrnsMRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
