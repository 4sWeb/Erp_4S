using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class InstprogramsRepo:Base_Repo<Instprogram>,IInstprograms
    {
        public InstprogramsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }   
    }
}
