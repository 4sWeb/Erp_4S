using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class StorespecappRepo : Base_Repo<Storespecapp>, IStorespecapp
    {

        public StorespecappRepo(ModelContext dbContext4S) : base(dbContext4S)
        {

        }

        public async Task<List<Storespecapp>> GetAllByAppID(int AppId)
        {
            return await GetByCondition(u => u.Appid == AppId);
        }
    }
}
