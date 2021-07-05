using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class FinancepuposesRepo:Base_Repo<Financepupose>,IFinancepuposes
    {
        public FinancepuposesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
