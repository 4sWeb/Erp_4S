using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class UserappsRepo:Base_Repo<Userapp>, IUserapps
    {
        public UserappsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
