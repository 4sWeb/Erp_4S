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
    [EnableCors("MyAllowSpecificOrigins")]
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
        public JsonResult TransactionSpecByID(decimal transCode,decimal userId)
        {
            var TransactionSpec = repo._StoreTrns.GetTransactionSpecsById(transCode);
            var listOfBranches = repo._branch.GetAllBranches(userId);
            TransactionSpec.TransactionMasterSpec_VM.Branches = listOfBranches;
            
            var branches = listOfBranches.Result.FirstOrDefault();
            Dictionary<string, object> currently = (Dictionary<string, object>)branches;
            var brancheId = int.Parse(currently.FirstOrDefault().Value.ToString());
            TransactionSpec.StoreTransMax = repo._StoreTrnsM.GetMaxID(transCode, 2, brancheId);

            TransactionSpec.TransactionMasterSpec_VM.From_Type = repo._Groupf.GetAllTypes(transCode, "F"); // Altaraf From
            TransactionSpec.TransactionMasterSpec_VM.To_Type = repo._Groupf.GetAllTypes(transCode, "T");   // Altaraf TO


            var listOfToType = repo._Groupf.GetAllToTypes(transCode);
            foreach (var item in listOfToType.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                var result = current.FirstOrDefault().Value;
               TransactionSpec.TransactionMasterSpec_VM.ToTypeDetails = repo._StoreAllcodes.GetByCondition(c=>c.GroupfId==decimal.Parse(result.ToString() )).Result.Select(n=>new { n.Code,n.Aname});

            }

            var listOfFromType = repo._Groupf.GetAllFromTypes(transCode);
            foreach (var item in listOfFromType.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                var result = current.FirstOrDefault().Value;
                TransactionSpec.TransactionMasterSpec_VM.FromTypeDetails = repo._StoreAllcodes.GetByCondition(c => c.GroupfId == decimal.Parse(result.ToString())).Result.Select(n => new { n.Code, n.Aname });

            }



            TransactionSpec.ExtraFields = repo._Extra.GetExtraByTrnsID(transCode);
            List<Transaction_VM> Items = new List<Transaction_VM>();
            Items = repo._StoreTrnsM.AllTransByDepID(TransactionSpec.TransactionDepSpec_VM.TransactionsNames.FirstOrDefault().Transaction_Id);
            TransactionSpec.TransactionDepSpec_VM.TrnsList = Items;
            return Json(TransactionSpec, new System.Text.Json.JsonSerializerOptions());
        }
        [HttpGet]
        [Route("GetTransactionsByDepID")]
        public JsonResult GetTransactionsByDepID(decimal DepTransID)
        {
            List<Transaction_VM> Items = new List<Transaction_VM>();
            Items = repo._StoreTrnsM.AllTransByDepID(DepTransID);
            return Json(Items, new System.Text.Json.JsonSerializerOptions());
        }
        [HttpPost]
        [Route("DisplayItems")]
        public JsonResult DisplayItems([FromBody]List<decimal> Items)
        {
            //List<decimal> Items = new List<decimal>() { 2872, 2878 };
            List<TransactionsDetails_VM> Results = repo._StoreTrnsO.GetTransactionsDetailsList(Items);
            return Json(Results, new System.Text.Json.JsonSerializerOptions());
        }



        [HttpPost]
        [Route("SaveOrder")]
        public JsonResult SaveOrder([FromBody] StoreTransMain_VM StoreTransMain_VM)
        {
            repo._StoreTrnsO.convert_VMtoModel(StoreTransMain_VM.StoreTransDetails_VM);
            repo._StoreTrnsDepDetails.convert_VMtoModel(StoreTransMain_VM.StoreTransDepDetails_VM);
            repo._StoreTrnsDep.convert_VMtoModel(StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault());
            repo._StoreTrnsM.convert_VMtoModel(StoreTransMain_VM.StoreTransMaster_VM);

            try
            {
                repo.Save();
            }
            catch (Exception ex)
            {
                return Json(new { ID = "-1", Result = "Bad Request" }, new System.Text.Json.JsonSerializerOptions());
            }

            return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpGet]
        [Route("Retrieve")]
        public StoreTransMain_VM Retrive(decimal storeTransMId)
        {
            StoreTransMain_VM STM_VM = new StoreTransMain_VM();
            if (storeTransMId !=default)
            {
                STM_VM.StoreTransMaster_VM = repo._StoreTrnsM.RetriveMasterTransactionById(storeTransMId);
                STM_VM.StoreTransDetails_VM = repo._StoreTrnsO.RetriveDetailsTransactionById(storeTransMId);
                var listOfPrevIds = repo._StoreTrnsDep.RetriveListPrevTransIds(storeTransMId);
                if (listOfPrevIds != null)
                {
                    STM_VM.StoreTransDep_VM = repo._StoreTrnsM.RetriveTransaDepById(listOfPrevIds);
                }
            }
            return STM_VM;
        }

        //public JsonResult SaveOrders([FromBody] StoreTransMain_VM StoreTransMain_VM)
        //{

        //    foreach (var row in TrnsO)
        //    {
        //        repo._StoreTrnsO.Create(row);
        //    }
        //    try
        //    {
        //        repo.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { ID = "-1", Result = "Bad Request" }, new System.Text.Json.JsonSerializerOptions());
        //    }

        //return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        //}

        //[HttpGet]
        //[Route("DisplayItems")]
        //public JsonResult DisplayItemsFromSelectedTransactions()
        //{
        //    // To Get All Items From Selected Transactions
        //    return Json(null);
        //}

    }
}
