using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class MainTypesRepo:Base_Repo<MainType>, IMainTypes
    {
        public MainTypesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
