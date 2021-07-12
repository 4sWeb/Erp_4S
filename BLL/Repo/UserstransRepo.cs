using BLL.IRepo;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class UserstransRepo:Base_Repo<Userstran>,IUserstrans
    {
        public UserstransRepo(ModelContext dbContext4S):base(dbContext4S)
        {
        }

        public async Task<List<Userstran>> GetByUserID(int id)
        {
            return await GetByCondition(s => s.Userid == id);
        }
    }
}
