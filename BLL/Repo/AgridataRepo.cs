using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class AgridataRepo:Base_Repo<Agridatum>, IAgridata
    {
        public AgridataRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
