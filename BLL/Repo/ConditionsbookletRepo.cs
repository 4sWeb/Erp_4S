using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class ConditionsbookletRepo:Base_Repo<Conditionsbooklet>,IConditionsbooklet
    {
        public ConditionsbookletRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
