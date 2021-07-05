using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class AgrifarmRepo:Base_Repo<Agrifarm>,IAgrifarm
    {
        public AgrifarmRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
