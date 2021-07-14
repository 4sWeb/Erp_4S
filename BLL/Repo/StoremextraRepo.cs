using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class StoremextraRepo :Base_Repo<Storemextra> , IStoremextra
    {
        public StoremextraRepo(ModelContext dbContext4S) : base(dbContext4S)
        {

        }
    }
}
