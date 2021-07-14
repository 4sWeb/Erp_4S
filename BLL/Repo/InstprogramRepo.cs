using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class InstprogramRepo:Base_Repo<Instprogram> , IInstprogram
    {
        public InstprogramRepo(ModelContext dbContext4S) : base(dbContext4S)
        {

        }
    }
}
