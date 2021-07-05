using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class AccountstreeRepo:Base_Repo<Accountstree>,IAccountstree
    {
        public AccountstreeRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
