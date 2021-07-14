using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class BranchRepo : Base_Repo<Branch1> , IBranch
    {
        public BranchRepo(ModelContext dbContext4S) : base(dbContext4S)
        {

        }

    }
}
