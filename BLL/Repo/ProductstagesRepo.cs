using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class ProductstagesRepo:Base_Repo<Productstage>, IProductstages
    {
        public ProductstagesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
