using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class AgriageRepo:Base_Repo<Agriage>,IAgriage
    {
        public AgriageRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
