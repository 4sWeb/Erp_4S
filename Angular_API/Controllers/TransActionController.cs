using Angular_API.ModelsView;
using BLL.IRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransActionController : Controller
    {
        private readonly IRepoWrapper repo;
        public TransActionController(IRepoWrapper _repo)
        {
            repo = _repo;
        }
        [HttpGet ]
       public  JsonResult TransActionsList() 
        {
            List<StoreTrans> storetrnslst = new List<StoreTrans>();
            var list = repo._StoreTrns.GetAll().Result.ToList().Select(s => new { s.TrnsCode, s.Aname, s.Ename }).OrderBy(c=>c.TrnsCode).ToList();
            foreach(var item in list) 
            {
                var _orderscount = repo._StoreTrnsM.GetByCondition(c => c.TrnsCode == item.TrnsCode).Result.Count ;
                storetrnslst.Add(new StoreTrans { trid = item.TrnsCode, AName = item.Aname, EName = item.Ename,Count= _orderscount });
            }
            return Json(storetrnslst , new System.Text.Json.JsonSerializerOptions());
           // return Json(repo._StoreTrnsM.Get(c => c.TrnsCode  == 2, c => c.OrderBy(c => c.TrnsCode), "StoreTrn").ToList(), new System.Text.Json.JsonSerializerOptions());
        }
    }
}
