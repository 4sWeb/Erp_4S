using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class DimensionsRepo:Base_Repo<Dimension>,IDimensions
    {
        public DimensionsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
