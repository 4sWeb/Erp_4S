using BLL.ERPModelsView.BasicData_VM;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
   public  interface ICurrencym:IBaseRepo<Currencym>
    {
        public List<CurrencyMaster_VM> GetAllCurrencyMaster();
        public object GetCurrencyMId();
        public void CreateCurrencyM(CurrencyMaster_VM currencyMaster);
    }
}
