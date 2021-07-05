using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class CurrencymRepo:Base_Repo<Currencym>,ICurrencym
    {
        public CurrencymRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
