using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsDepDetailsRepo:Base_Repo<StoreTrnsDepDetail>, IStoreTrnsDepDetails
    {
        public StoreTrnsDepDetailsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
