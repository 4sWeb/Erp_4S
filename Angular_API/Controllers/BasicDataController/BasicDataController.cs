using BLL.ERPModelsView.BasicData_VM;
using BLL.IRepo;
using DAL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_API.Controllers.BasicDataController
{
    [ApiController]
    [Route("BasicData")]
    [EnableCors("MyAllowSpecificOrigins")]
    public class BasicDataController : Controller 
    {
        private readonly IRepoWrapper repo;

        public BasicDataController(IRepoWrapper _repo)
        {
            repo = _repo;
        }

        //********************************UNITES CRUD OPERTION*****************************//
        [HttpGet]
        [Route("DisplayAllUnites")]
        public JsonResult UnitesList()
        {

         var unites_vm=   repo._StoreUnits.GetAll().Result.Select(s=>new UnitesBasic_VM 
         {
             UniteId=s.Unitid,
             Aname=s.Aname,
             Ename=s.Ename,
             Saname=s.Saname,
             Sename=s.Sename
         });
             return Json(unites_vm, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpPost  ]
        [Route("CreateUnite")]
        public JsonResult CreateUnite([FromBody]UnitesBasic_VM unites_VM)
        {
            var GetNext = (Dictionary<string, object>)repo.CallQuery("select STORE_UNITS_SEQ.NEXTVAL from dual").Result.FirstOrDefault();
            object NextValue = GetNext.GetValueOrDefault("NEXTVAL");
            StoreUnit StoreUnit = new StoreUnit()
            { 
                Aname = unites_VM.Aname,
                Ename = unites_VM.Ename,
                Saname = unites_VM.Saname,
                Sename = unites_VM.Sename
            };
            repo._StoreUnits.Create(StoreUnit);
            try
            {
                repo.Save();
            }
            catch (Exception e) { }

            return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpPost]
        [Route("EditUnite")]
        public JsonResult EditUnite([FromBody] UnitesBasic_VM NewUnites_VM)
        {
            StoreUnit StoreUnit = new StoreUnit()
            {
                Unitid= NewUnites_VM.UniteId,
                Aname = NewUnites_VM.Aname,
                Ename = NewUnites_VM.Ename,
                Saname = NewUnites_VM.Saname,
                Sename = NewUnites_VM.Sename
            };
            repo._StoreUnits.Update(StoreUnit);

            try
            {
                repo.Save();
            }
            catch (Exception) { }

            return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpGet]
        [Route("deleteUnite")]
        public JsonResult deleteUnite(decimal uniteId)
        {
            if (uniteId!=default)
            {
              var item=  repo._StoreItemUnits.GetByCondition(c => c.Unitid == uniteId);
                if (item.Result.Count != 0)
                {
                    return Json(new { ID = "200", Result = "you can not delete this unite as it uesd by item" });
                }
                else
                {
                    try
                    {
                        repo.CallQuery("delete STORE_UNITS where UNITID= " + uniteId + " ", null, 2);
                    }
                    catch (Exception ex) { }
                }
               
            }
            
            return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        }



        //********************************CURRENCY CRUD OPERTION*****************************//
        [HttpGet]
        [Route("DisplayAllCurrency")]
        public JsonResult CurrencyList()
        {
            List<CurrencyMain_VM> currencyMains = new List<CurrencyMain_VM>();

           var currencuMaster= repo._Currencym.GetAllCurrencyMaster();

            foreach (var item in currencuMaster)
            {
              var currencyRate=  repo._Currencyo.GetAllCurrencyRates(item.Id);
                currencyMains.Add(new CurrencyMain_VM {CurrencyMaster_VM= item,CurrencyRates_VM= currencyRate } );
               
            }
            

            return Json(currencyMains, new System.Text.Json.JsonSerializerOptions());
        }


        [HttpPost]
        [Route("CreateCurrency")]
        public JsonResult CreateCurrency([FromBody] CurrencyMain_VM currencyMain)
        {
            var GetNext = (Dictionary<string, object>)repo.CallQuery("select CURRENCYM_SEQ.NEXTVAL from dual").Result.FirstOrDefault();
            object CurrencyMId = GetNext.GetValueOrDefault("NEXTVAL");

            if (currencyMain.CurrencyMaster_VM.Id != default)
            {
                foreach (var item in currencyMain.CurrencyRates_VM)
                {
                    Currencyo currencyo = new Currencyo
                    {
                        Currmid = currencyMain.CurrencyMaster_VM.Id,
                        Indate = item.Indate,
                        Rate = item.Rate

                    };
                    repo._Currencyo.Create(currencyo);
                }

               
            }

            else
            {
                Currencym currencym = new Currencym
                {
                    Aname = currencyMain.CurrencyMaster_VM.Aname,
                    Ename = currencyMain.CurrencyMaster_VM.Ename,
                    Shortname = currencyMain.CurrencyMaster_VM.Shortname,
                    AcurrUnit1= currencyMain.CurrencyMaster_VM.AcurrUnit1,
                    AcurrUnit2= currencyMain.CurrencyMaster_VM.AcurrUnit2,
                    AcurrUnit3= currencyMain.CurrencyMaster_VM.AcurrUnit3,
                    AcurrUnit4= currencyMain.CurrencyMaster_VM.AcurrUnit4,
                    AfracUnit1= currencyMain.CurrencyMaster_VM.AfracUnit1,
                    AfracUnit2= currencyMain.CurrencyMaster_VM.AfracUnit2,
                    AfracUnit3= currencyMain.CurrencyMaster_VM.AfracUnit3,
                    AfracUnit4= currencyMain.CurrencyMaster_VM.AfracUnit4,
                    EcurrUnit1= currencyMain.CurrencyMaster_VM.EcurrUnit1,
                    EcurrUnit2=currencyMain.CurrencyMaster_VM.EcurrUnit2,
                    EcurrUnit3=currencyMain.CurrencyMaster_VM.EcurrUnit3,
                    EcurrUnit4= currencyMain.CurrencyMaster_VM.EcurrUnit4,
                    EfracUnit1 =currencyMain.CurrencyMaster_VM.EfracUnit1,
                    EfracUnit2 =currencyMain.CurrencyMaster_VM.EfracUnit2,
                    EfracUnit3 =currencyMain.CurrencyMaster_VM.EfracUnit3,
                    EfracUnit4 = currencyMain.CurrencyMaster_VM.EfracUnit4,
                    Isdefault= currencyMain.CurrencyMaster_VM.Isdefault,
                };

                repo._Currencym.Create(currencym);
               


                foreach (var item in currencyMain.CurrencyRates_VM)
                {
                    Currencyo currencyo = new Currencyo
                    {
                        Currmid = decimal.Parse(CurrencyMId.ToString()) + 1,
                        Indate = item.Indate,
                        Rate = item.Rate

                    };
                    repo._Currencyo.Create(currencyo);
                }

            }

            try
            {
                repo.Save();
            }
            catch (Exception e) { }

            return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpPost]
        [Route("EditCurrency")]
        public JsonResult EditCurrency([FromBody] CurrencyMain_VM currencyMain)
        {
          
                Currencym currencym = new Currencym
            {
                    Id= currencyMain.CurrencyMaster_VM.Id,
                    Aname = currencyMain.CurrencyMaster_VM.Aname,
                    Ename = currencyMain.CurrencyMaster_VM.Ename,
                    Shortname = currencyMain.CurrencyMaster_VM.Shortname,
                    AcurrUnit1 = currencyMain.CurrencyMaster_VM.AcurrUnit1,
                    AcurrUnit2 = currencyMain.CurrencyMaster_VM.AcurrUnit2,
                    AcurrUnit3 = currencyMain.CurrencyMaster_VM.AcurrUnit3,
                    AcurrUnit4 = currencyMain.CurrencyMaster_VM.AcurrUnit4,
                    AfracUnit1 = currencyMain.CurrencyMaster_VM.AfracUnit1,
                    AfracUnit2 = currencyMain.CurrencyMaster_VM.AfracUnit2,
                    AfracUnit3 = currencyMain.CurrencyMaster_VM.AfracUnit3,
                    AfracUnit4 = currencyMain.CurrencyMaster_VM.AfracUnit4,
                    EcurrUnit1 = currencyMain.CurrencyMaster_VM.EcurrUnit1,
                    EcurrUnit2 = currencyMain.CurrencyMaster_VM.EcurrUnit2,
                    EcurrUnit3 = currencyMain.CurrencyMaster_VM.EcurrUnit3,
                    EcurrUnit4 = currencyMain.CurrencyMaster_VM.EcurrUnit4,
                    EfracUnit1 = currencyMain.CurrencyMaster_VM.EfracUnit1,
                    EfracUnit2 = currencyMain.CurrencyMaster_VM.EfracUnit2,
                    EfracUnit3 = currencyMain.CurrencyMaster_VM.EfracUnit3,
                    EfracUnit4 = currencyMain.CurrencyMaster_VM.EfracUnit4,
                    Isdefault = currencyMain.CurrencyMaster_VM.Isdefault,
                };

            repo._Currencym.Update(currencym);
            foreach (var item in currencyMain.CurrencyRates_VM)
            {
                var check = repo._StoreTrnsM.GetByCondition(s => s.CurrencyOId == item.Id);
                if (check.Result.Count != 0)
                {
                    return Json(new { ID = "200", Result = "you can not edit this rate as it uesd by transaction" });
                }
                {

                }
                Currencyo currencyo = new Currencyo
                {
                    Id=item.Id,
                    Currmid = item.Currmid,
                    Indate = item.Indate,
                    Rate = item.Rate

                };
                repo._Currencyo.Update(currencyo);
            }

            try
            {
                repo.Save();
            }
            catch (Exception e) { }

            return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpGet]
        [Route("DeleteCurrency")]
        public JsonResult DeleteCurrency(decimal currencyId)
        {
            if (currencyId != default)
            {
                var item = repo._StoreTrnsM.GetByCondition(c => c.Currencyid == currencyId);
                if (item.Result.Count != 0)
                {
                    return Json(new { ID = "200", Result = "you can not delete this unite as it uesd by item" });
                }
                else
                {
                    try
                    {
                        repo.CallQuery("delete CURRENCYM where ID= " + currencyId + " ", null, 2);
                    }
                    catch (Exception ex) { }
                }

            }
            return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        }


    }

}
