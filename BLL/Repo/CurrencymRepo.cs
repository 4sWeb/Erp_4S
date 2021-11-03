using BLL.ERPModelsView.BasicData_VM;
using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class CurrencymRepo:Base_Repo<Currencym>,ICurrencym
    {
        private readonly IRepoWrapper repo;
        public CurrencymRepo(ModelContext dbContext4S) :base(dbContext4S)
        {
           
        }
        public List<CurrencyMaster_VM> GetAllCurrencyMaster()
        {
           var CurrencyMaster_VM=  GetAll().Result.Select(s => new CurrencyMaster_VM
            {
                Id = s.Id,
                Aname = s.Aname,
                Ename = s.Ename,
                AcurrUnit1 = s.AcurrUnit1,
                AcurrUnit2 = s.AcurrUnit2,
                AcurrUnit3 = s.AcurrUnit3,
                AcurrUnit4 = s.AcurrUnit4,
                AfracUnit1 = s.AfracUnit1,
                AfracUnit2 = s.AfracUnit2,
                AfracUnit3 = s.AfracUnit3,
                AfracUnit4 = s.AfracUnit4,
                EcurrUnit1 = s.EcurrUnit1,
                EcurrUnit2 = s.EcurrUnit2,
                EcurrUnit3 = s.EcurrUnit3,
                EcurrUnit4 = s.EcurrUnit4,
                Shortname = s.Shortname,
                EfracUnit1 = s.EfracUnit1,
                EfracUnit2 = s.EfracUnit2,
                EfracUnit3 = s.EfracUnit3,
                EfracUnit4 = s.EfracUnit4,
                Isdefault = s.Isdefault
            }).ToList();
            return CurrencyMaster_VM;
        }
        
       
       public object GetCurrencyMId()
        {
            var GetNext = (Dictionary<string, object>)repo.CallQuery("select CURRENCYM_SEQ.NEXTVAL from dual").Result.FirstOrDefault();
            object CurrencyMId = GetNext.GetValueOrDefault("NEXTVAL");
            return CurrencyMId;
        }
        public void CreateCurrencyM(CurrencyMaster_VM currencyMaster)
        {
            Currencym currencym = new Currencym
            {
                Aname = currencyMaster.Aname,
                Ename=currencyMaster.Ename,
                Shortname=currencyMaster.Shortname
            };

            Create(currencym);
            try
            {
                repo.Save();
            }
            catch (Exception e) { }
        }
    }
}
