using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class DiscountListTypeRepo:Base_Repo<DiscountListType>,IDiscountListType
    {
        public DiscountListTypeRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
