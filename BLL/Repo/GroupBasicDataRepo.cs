using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class GroupBasicDataRepo:Base_Repo<GroupBasicDatum>,IGroupBasicData
    {
        public GroupBasicDataRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
