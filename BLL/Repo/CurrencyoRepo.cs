﻿using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class CurrencyoRepo:Base_Repo<Currencyo>,ICurrencyo
    {
        public CurrencyoRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
