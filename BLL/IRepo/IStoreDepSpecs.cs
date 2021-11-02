using BLL.ERPModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreDepSpecs:IBaseRepo<StoreDepSpec>
    {
        List<StoreDepSpec> GetAllStoreDepSpecById(decimal id);
    }
}
