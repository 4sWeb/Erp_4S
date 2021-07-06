using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repo
{
    public class StaffRepo:Base_Repo<staff>, IStaff
    {
        public StaffRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
    }
}
