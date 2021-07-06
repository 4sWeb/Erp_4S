using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class ProductformladetailsRepo:Base_Repo<Productformladetail>, IProductformladetails
    {
        public ProductformladetailsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
