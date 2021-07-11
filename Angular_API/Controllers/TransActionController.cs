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

            /// List_UserTrns  From Table UserTrns
            /// if(ListUserTrns == null)
            /// {
            ///     List_StoreSpecsApp From Table StoreSpecsApp  (select Trns_Code)
            ///     List_StoreTrns From Table StoreTrns  ( select TrnsCode, AName , EName )
            ///     foreach(var Item in List_StoreTrns)
            ///     {
            ///          var CheckedTrns = List_StoreSpecsApp.firstOrDefault(TrnsCode == Item.TrnsCode);
            ///          if(CheckedTrns == null)
            ///             List_StoreTrns.removed(Items);
            ///     }else{
            ///          Get Count from Store_TrnsM in Column Count
            ///     }
            /// }
            /// else{
            ///     List_StoreSpecsApp From Table StoreSpecsApp  (select Trns_Code)
            ///     foreach(var Item in List_StoreSpecsApp)
            ///     {
            ///         var Checked = List_UserTrns.firstOrDefault( TrnsCode == Item)
            ///         if(Checked == null)
            ///             List_StoreSpecsApp.removed(Item);
            ///     }
            ///     List_StoreTrns From Table StoreTrns  ( select TrnsCode, AName , EName )
            ///     foreach(var Item in List_StoreTrns)
            ///     {
            ///          var CheckedTrns = List_StoreSpecsApp.firstOrDefault(TrnsCode == Item.TrnsCode);
            ///          if(CheckedTrns == null)
            ///             List_StoreTrns.removed(Items);
            ///     }else{
            ///          Get Count from Store_TrnsM in Column Count
            ///     }
            /// }
            var UserID = 1;
            var ListUserApp = repo._Userstrans.GetByCondition(u => u.Userid == UserID).Result;
            if(ListUserApp.Count == 0)
            {
                var ListStoreSpecsApp = repo._Storepecsapp.GetByCondition(u => u.Appid == 2).Result;
                var ListStoreTrns = repo._StoreTrns.GetAll().Result.Select(s => new { s.TrnsCode, s.Aname, s.Ename }).ToList();
                foreach (var item in ListStoreTrns.ToList())
                {
                    var Checked = ListStoreSpecsApp.FirstOrDefault(s => s.Storespecid == item.TrnsCode);
                    if (Checked == null)
                        ListStoreTrns.Remove(item);
                    else
                    {
                        var _orderscount = repo._StoreTrnsM.GetByCondition(c => c.TrnsCode == item.TrnsCode).Result.Count;
                        storetrnslst.Add(new StoreTrans { trid = item.TrnsCode, AName = item.Aname, EName = item.Ename, Count = _orderscount });
                    }
                }
            }
            else
            {
                var ListStoreSpecsApp = repo._Storepecsapp.GetAll().Result;
                foreach (var item in ListStoreSpecsApp)
                {
                    var Checked = ListUserApp.FirstOrDefault(u => u.Transcode == item.Storespecid.ToString());
                    if (Checked == null)
                        ListStoreSpecsApp.Remove(item);
                }

                var ListStoreTrns = repo._StoreTrns.GetAll().Result.Select(s => new { s.TrnsCode, s.Aname, s.Ename }).ToList();
                foreach (var item in ListStoreTrns)
                {
                    var Checked = ListStoreSpecsApp.FirstOrDefault(s => s.Storespecid == item.TrnsCode);
                    if (Checked == null)
                        ListStoreTrns.Remove(item);
                    else
                    {
                        var _orderscount = repo._StoreTrnsM.GetByCondition(c => c.TrnsCode == item.TrnsCode).Result.Count;
                        storetrnslst.Add(new StoreTrans { trid = item.TrnsCode, AName = item.Aname, EName = item.Ename, Count = _orderscount });
                    }
                }

            }


            //var list = repo._StoreTrns.GetAll().Result.ToList().Select(s => new { s.TrnsCode, s.Aname, s.Ename }).OrderBy(c=>c.TrnsCode).ToList();
            //foreach(var item in list) 
            //{
            //    var _orderscount = repo._StoreTrnsM.GetByCondition(c => c.TrnsCode == item.TrnsCode).Result.Count ;
            //    storetrnslst.Add(new StoreTrans { trid = item.TrnsCode, AName = item.Aname, EName = item.Ename,Count= _orderscount });
            //}
            return Json(storetrnslst , new System.Text.Json.JsonSerializerOptions());
           // return Json(repo._StoreTrnsM.Get(c => c.TrnsCode  == 2, c => c.OrderBy(c => c.TrnsCode), "StoreTrn").ToList(), new System.Text.Json.JsonSerializerOptions());
        }
    }
}
