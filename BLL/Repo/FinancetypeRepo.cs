using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class FinancetypeRepo:Base_Repo<Financetype>,IFinancetype
    {
        public FinancetypeRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
