using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class UsersRepo:Base_Repo<User>, IUsers
    {
        public UsersRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
