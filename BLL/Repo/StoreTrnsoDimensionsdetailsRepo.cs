using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsoDimensionsdetailsRepo:Base_Repo<StoreTrnsoDimensionsdetail>, IStoreTrnsoDimensionsdetails
    {
        public StoreTrnsoDimensionsdetailsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
