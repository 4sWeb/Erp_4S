using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsProducationformlaRepo:Base_Repo<StoreTrnsProducationformla>, IStoreTrnsProducationformla
    {
        public StoreTrnsProducationformlaRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
