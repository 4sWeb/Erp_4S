using BLL.ERPModelsView.BasicData_VM;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface ICurrencyo:IBaseRepo<Currencyo>
    {
        public List<CurrencyRates_VM> GetAllCurrencyRates(decimal CurrncyMasterId);
    }
}
