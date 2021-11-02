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

        [HttpPut]
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


        }
}
