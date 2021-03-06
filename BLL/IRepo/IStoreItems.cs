using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepo
{
    public interface IStoreItems:IBaseRepo<StoreItem>
    {
        Task<List<object>> GetItemsDetails(decimal Id);
        Task<List<object>> GetGroupFIDForItem(decimal Id);
        Task<List<object>> GetGroupFNameForItem(decimal Id);
    }
}
