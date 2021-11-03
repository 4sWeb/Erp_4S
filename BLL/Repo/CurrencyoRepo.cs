using BLL.ERPModelsView.BasicData_VM;
using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class CurrencyoRepo:Base_Repo<Currencyo>,ICurrencyo
    {
        private readonly IRepoWrapper repo;
        public CurrencyoRepo(ModelContext dbContext4S):base(dbContext4S)
        {
          
        }
        public List<CurrencyRates_VM> GetAllCurrencyRates(decimal CurrncyMasterId)
        {
            var CurrencyRates_VM = GetByCondition(s=>s.Currmid==CurrncyMasterId).Result.Select(s => new CurrencyRates_VM
            {
                Id = s.Id,
                Rate=s.Rate,
                Indate=s.Indate,
                Currmid=s.Currmid
                
            }).ToList();
            return CurrencyRates_VM;
        }


      
    }
}
