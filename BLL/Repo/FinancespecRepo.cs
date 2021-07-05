using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class FinancespecRepo:Base_Repo<Financespec>,IFinancespec
    {
        public FinancespecRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
