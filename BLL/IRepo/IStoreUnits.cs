using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepo
{
    public interface IStoreUnits:IBaseRepo<StoreUnit>
    {
        Task<List<object>> GetUnitesDetails(decimal storeItemId);
    }
}
