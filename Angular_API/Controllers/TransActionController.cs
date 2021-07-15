using BLL.IRepo;
using BLL.ModelsView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_API.Controllers
{
    [ApiController]
    [Route("Transaction")]
    public class TransActionController : Controller
    {
        private readonly IRepoWrapper repo;
        public TransActionController(IRepoWrapper _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        public JsonResult TransActionsList(int UserID = 1, int AppID = 2, int PeriodID = 2)
        {
            List<StoreTrans> storetrnslst = new List<StoreTrans>();

            var ListUserApp = repo._Userstrans.GetByUserID(UserID).Result;
            var ListStoreSpecsApp = repo._Storepecsapp.GetAllByAppID(AppID).Result;
            if (ListUserApp.Count > 0)
            {
                foreach (var item in ListStoreSpecsApp.ToList())
                {
                    var Checked = ListUserApp.FirstOrDefault(u => u.Transcode == item.Storespecid.ToString());
                    if (Checked == null)
                        ListStoreSpecsApp.Remove(item);
                }
            }
            storetrnslst = repo._StoreTrns.AllTransactionInModul(ListStoreSpecsApp);
            return Json(storetrnslst, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpGet]
        [Route("DisplayAllTransaction")]
        public JsonResult DisplayAllTransactionById(decimal id , int PeriodID)
        {
            var ListTransactions = repo._StoreTrnsM.AllTransactionByIdAndPeriodId(id, PeriodID);
            return Json(ListTransactions , new System.Text.Json.JsonSerializerOptions());
        }

        [HttpGet]
        [Route("TransactionSpec")]
        public JsonResult TransactionSpecByID(decimal id)
        {
            var TransactionSpec = repo._StoreTrns.GetTransactionSpecsById(id);
            return Json(TransactionSpec, new System.Text.Json.JsonSerializerOptions());
        }
    }
}
