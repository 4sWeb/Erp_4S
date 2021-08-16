using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrnsDepDetails:IBaseRepo<StoreTrnsDepDetail>
    {
        public void convert_VMtoModel(List<StoreTransDepDetails_VM> STD_VM);
    }
}
