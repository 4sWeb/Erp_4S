using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class UserstransRepo:Base_Repo<Userstran>,IUserstrans
    {
        public UserstransRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
