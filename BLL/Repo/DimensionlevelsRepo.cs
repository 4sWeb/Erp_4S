using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
   public  class DimensionlevelsRepo:Base_Repo<Dimensionlevel>,IDimensionlevels
    {
        public DimensionlevelsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
