﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoredsttypes:IBaseRepo<Storedsttype>
    {
        List<Storedsttype> ListStoreDstTypeByTransID(decimal id, string type);
    }
}
