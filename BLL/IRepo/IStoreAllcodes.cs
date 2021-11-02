using BLL.ERPModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreAllcodes:IBaseRepo<StoreAllcode>
    {
        StoreAllcode GetStoreAllCodeById(decimal? id);
        List<Sales_Rep_VM> GetAllSalesRep(decimal Id);
    }
}
