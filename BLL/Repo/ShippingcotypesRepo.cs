﻿using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class ShippingcotypesRepo:Base_Repo<Shippingcotype>, IShippingcotypes
    {
        public ShippingcotypesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
