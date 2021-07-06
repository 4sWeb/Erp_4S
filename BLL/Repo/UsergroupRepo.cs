using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class UsergroupRepo:Base_Repo<Usergroup>, IUsergroup
    {
        public UsergroupRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
