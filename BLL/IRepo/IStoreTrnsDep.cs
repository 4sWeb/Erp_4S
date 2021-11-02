using BLL.ERPModelsView;
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
        StoreTransDep_VM RetrieveTransactions(decimal storeTrnsMId);
        List<decimal> RetriveListTransDepIds(decimal previousId,decimal cTransrowId);
    }
}
