using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class UserperiodRepo:Base_Repo<Userperiod>, IUserperiod
    {
        public UserperiodRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
