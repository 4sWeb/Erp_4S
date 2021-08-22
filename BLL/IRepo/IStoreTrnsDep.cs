using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrnsDep:IBaseRepo<StoreTrnsDep>
    {
        public void convert_VMtoModel(StoreTransDep_VM StoreTransDep_VM);
        List<decimal> RetriveListPrevTransIds(decimal storeTransMId);
    }
}
