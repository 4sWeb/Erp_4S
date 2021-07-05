using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class DiscountItemMRepo:Base_Repo<DiscountItemM>,IDiscountItemM
    {
        public DiscountItemMRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
