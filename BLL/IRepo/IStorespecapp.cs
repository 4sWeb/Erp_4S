using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepo
{
    public interface IStorespecapp:IBaseRepo<Storespecapp>
    {
        Task<List<Storespecapp>> GetAllByAppID(int AppId);
    }
}
