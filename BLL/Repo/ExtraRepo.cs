using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class ExtraRepo:Base_Repo<Extra>,IExtra
    {
        public ExtraRepo(ModelContext dbContext4S) : base(dbContext4S)
        {

        }
    }
}
