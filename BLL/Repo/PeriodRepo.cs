using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class PeriodRepo:Base_Repo<Period>, IPeriod
    {
        public PeriodRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
