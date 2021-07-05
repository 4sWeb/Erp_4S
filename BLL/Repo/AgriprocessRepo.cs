using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class AgriprocessRepo:Base_Repo<Agriprocess>,IAgriprocess
    {
        public AgriprocessRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
