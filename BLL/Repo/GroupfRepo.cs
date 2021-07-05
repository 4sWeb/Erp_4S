using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class GroupfRepo:Base_Repo<Groupf>,IGroupf
    {
        public GroupfRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
