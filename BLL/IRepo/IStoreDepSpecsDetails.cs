using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreDepSpecsDetails:IBaseRepo<StoreDepSpecsDetail>
    {
        public StoreDepSpecDetails_VM GetSpecificationForStoreDep(decimal StoreDepSpecID);
    }
}
