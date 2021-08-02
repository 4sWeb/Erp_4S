using BLL.IRepo;
using BLL.ModelsView;
using BLL.Repo;
using DAL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_API.Controllers
{
    [ApiController]
    [Route("Transaction")]
    [EnableCors("AllowOrigia")]
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
            storetrnslst = repo._StoreTrns.AllTransactionInModul(ListStoreSpecsApp, PeriodID);
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
            TransactionSpec.From_Type = repo._Groupf.GetAllTypes(id, "F"); // Altaraf From
            TransactionSpec.To_Type = repo._Groupf.GetAllTypes(id, "T");   // Altaraf TO

            TransactionSpec.ExtraFields = repo._Extra.GetExtraByTrnsID(id);

            /////////////////////////
            Dictionary<string, object> par = new Dictionary<string, object>();
            par.Add("@DepDetID", null );
            par.Add("@TRANSCODE", TransactionSpec.TransactionsNames.FirstOrDefault().Transaction_Id);

            var TransList = repo.CallQuery("GetdepremaningqtyAllTrans2", par, 1);

            List<Transaction_VM> Items = new List<Transaction_VM>();
            foreach (var item in TransList.Result.ToList())
            {
                Dictionary<string, object> Current = (Dictionary<string, object>)item;
                var NewItem = repo._StoreTrnsM.GetByCondition(c => c.StoreTrnsMId == decimal.Parse(Current.GetValueOrDefault("MID").ToString())).Result.Select(s => new { s.TrnsCode, s.TrnsDate, s.TrnsNo, s.StoreTrnsMId });
                Items.Add(new Transaction_VM { StoreTrnsMId = NewItem.FirstOrDefault().StoreTrnsMId, TrnsCode = NewItem.FirstOrDefault().TrnsCode, TrnsDate = NewItem.FirstOrDefault().TrnsDate, TrnsNo = NewItem.FirstOrDefault().TrnsNo });
            }

            TransactionSpec.TrnsList = Items;
            /////////////////////

            return Json(TransactionSpec, new System.Text.Json.JsonSerializerOptions());
        }


        //[HttpGet]
        //[Route("DisplayItems")]
        //public JsonResult DisplayItemsFromSelectedTransactions()
        //{
        //    // To Get All Items From Selected Transactions
        //    return Json(null);
        //}

    }
}
