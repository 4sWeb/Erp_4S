using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StagesRepo:Base_Repo<Stage>, IStages
    {
        public StagesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
