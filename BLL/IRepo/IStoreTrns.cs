using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IStoreTrns:IBaseRepo<StoreTrn>
    {
        List<StoreTrans> AllTransactionInModul(List<Storespecapp> ListStoreSpecsApp);
    } 
}
