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
        public JsonResult DisplayAllTransactionById(decimal id, int PeriodID)
        {
            var ListTransactions = repo._StoreTrnsM.AllTransactionByIdAndPeriodId(id, PeriodID);
            return Json(ListTransactions, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpGet]
        [Route("TransactionSpec")]
        public JsonResult TransactionSpecByID(decimal transCode, decimal userId)
        {
            var TransactionSpec = repo._StoreTrns.GetTransactionSpecsById(transCode);
            var listOfBranches = repo._branch.GetAllBranches(userId);
            List<Branches_VM> branches_VMs = new List<Branches_VM>();
            foreach(var item in listOfBranches.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                branches_VMs.Add(new Branches_VM { BRANCH_ID = int.Parse(current.Values.First().ToString()),NAME = current.Values.Last().ToString() });
            }
            TransactionSpec.TransactionMasterSpec_VM.Branches = branches_VMs;

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
                TransactionSpec.TransactionMasterSpec_VM.ToTypeDetails = repo._StoreAllcodes.GetByCondition(c => c.GroupfId == decimal.Parse(result.ToString())).Result.Select(n => new { n.Aname, n.StoreAllcodesId });

            }

            var listOfFromType = repo._Groupf.GetAllFromTypes(transCode);
            foreach (var item in listOfFromType.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                var result = current.FirstOrDefault().Value;
                TransactionSpec.TransactionMasterSpec_VM.FromTypeDetails = repo._StoreAllcodes.GetByCondition(c => c.GroupfId == decimal.Parse(result.ToString())).Result.Select(n => new { n.Code, n.Aname, n.StoreAllcodesId });

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
            foreach (var item in Items)
            {
                var ii = repo._StoreTrnsDep.RetrieveTransactions(item.StoreTrnsMId);
                item.StoreTransDep_VM = ii;
            }

            return Json(Items, new System.Text.Json.JsonSerializerOptions());
        }
        [HttpPost]
        [Route("DisplayItems")]
        public JsonResult DisplayItems([FromBody] List<decimal> Items)
        {
            //List<decimal> Items = new List<decimal>() { 2872, 2878 };
            List<StoreTransDetails_VM> Results = repo._StoreTrnsO.GetTransactionsDetailsList(Items);
            return Json(Results, new System.Text.Json.JsonSerializerOptions());
        }



        [HttpPost]
        [Route("SaveOrder")]
        public JsonResult SaveOrder([FromBody] StoreTransMain_VM StoreTransMain_VM)
        {
            StoreTrnsM StoreTrnsM = new StoreTrnsM()
            {
                TrnsCode = StoreTransMain_VM.StoreTransMaster_VM.TrnsCode,
                Rem = StoreTransMain_VM.StoreTransMaster_VM.Rem,
                TrnsNo = StoreTransMain_VM.StoreTransMaster_VM.TrnsNo,
                BranchId = StoreTransMain_VM.StoreTransMaster_VM.BranchId,
                TrnsDate = StoreTransMain_VM.StoreTransMaster_VM.TrnsDate,
                Storedocnum = StoreTransMain_VM.StoreTransMaster_VM.Storedocnum,
                FromStoreAllcodesId = StoreTransMain_VM.StoreTransMaster_VM.FromStoreAllcodesId,
                ToStoreAllcodesId = StoreTransMain_VM.StoreTransMaster_VM.ToStoreAllcodesId,
                Period = StoreTransMain_VM.StoreTransMaster_VM.Period,
                StoreTrnsMId = StoreTransMain_VM.StoreTransMaster_VM.StoreTrnsMId,
                Disc = StoreTransMain_VM.StoreTransMaster_VM.Disc,
                DiscRate = StoreTransMain_VM.StoreTransMaster_VM.DiscRate,
                Stax = StoreTransMain_VM.StoreTransMaster_VM.Stax,
                StaxRate = StoreTransMain_VM.StoreTransMaster_VM.StaxRate,
                DepOnGroupno = StoreTransMain_VM.StoreTransMaster_VM.DepOnGroupno,
                CtaxDisc = StoreTransMain_VM.StoreTransMaster_VM.CtaxDisc,
                CtaxDiscRate = StoreTransMain_VM.StoreTransMaster_VM.CtaxDiscRate,
                Total = StoreTransMain_VM.StoreTransMaster_VM.Total,
                Currencyid = StoreTransMain_VM.StoreTransMaster_VM.Currencyid,
                Currencyrate = StoreTransMain_VM.StoreTransMaster_VM.Currencyrate,
                Pricelistid = StoreTransMain_VM.StoreTransMaster_VM.Pricelistid,
                PeriodLimit = StoreTransMain_VM.StoreTransMaster_VM.PeriodLimit,
                Disc2 = StoreTransMain_VM.StoreTransMaster_VM.Disc2,
                Disc2Rate = StoreTransMain_VM.StoreTransMaster_VM.Disc2Rate,
                Addition1 = StoreTransMain_VM.StoreTransMaster_VM.Addition1,
                Addition1Rate = StoreTransMain_VM.StoreTransMaster_VM.Addition1Rate,
                Addition2 = StoreTransMain_VM.StoreTransMaster_VM.Addition2,
                Addition2Rate = StoreTransMain_VM.StoreTransMaster_VM.Addition2Rate,
                Addition3 = StoreTransMain_VM.StoreTransMaster_VM.Addition3,
                Addition3Rate = StoreTransMain_VM.StoreTransMaster_VM.Addition3Rate,
                Trnsusersid = StoreTransMain_VM.StoreTransMaster_VM.Trnsusersid,
                Employeeno = StoreTransMain_VM.StoreTransMaster_VM.Employeeno,
                MainAccountid = StoreTransMain_VM.StoreTransMaster_VM.MainAccountid,
                MainCostcenterid = StoreTransMain_VM.StoreTransMaster_VM.MainCostcenterid
            };

            repo._StoreTrnsM.Create(StoreTrnsM);


            //Add StoreTransDetails
            foreach (var item in StoreTransMain_VM.StoreTransDetails_VM)
            {
                StoreTrnsO StoreTrnsO = new StoreTrnsO
                {
                    StoreTrnsOId = item.storeTrnsOId,
                    Qty = item.qty,
                    UnitId = item.unitId,
                    UnitPrice = item.unitPrice,
                    Notes = item.notes,
                    ItemId = item.itemId,
                    Itemapproved = item.itemapproved,
                    StoretrnsProformlaId = item.storetrnsProformlaId,
                    Totalo = item.totalo,
                    Weekno = item.weekno,
                    StoreTrnsMId = item.storeTrnsMId,
                    Todate = item.todate,
                    StaxVal = item.staxVal,
                    UnitOldprice = item.unitOldprice,
                    ItemKind = item.itemKind,
                    ItemCost = item.itemCost,
                    DiscVal = item.discVal,
                    Agriqty = item.agriqty,
                    Item2nddiscVal = item.item2nddiscVal,
                };
                if (StoreTrnsO != null)
                {
                    repo._StoreTrnsO.Create(StoreTrnsO);

                }

            }


            StoreTrnsDep storeTrnsDep = new StoreTrnsDep()
            {
                Ptransrowid = StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault().Ptransrowid,
                Groupid = StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault().Groupid,
                Commited = StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault().Commited,
                Depslot = StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault().Depslot,
                Depdetailsid = StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault().Depdetailsid,
                StoreTrnsDepId = StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault().StoreTrnsDepId,
                Ctrnsrowid = StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault().Ctrnsrowid,

            };
            if (storeTrnsDep != null)
            {
                repo._StoreTrnsDep.Create(storeTrnsDep);
            }

            foreach (var item in StoreTransMain_VM.StoreTransDepDetails_VM)
            {
                StoreTrnsDepDetail storeTransDepDetails = new StoreTrnsDepDetail()
                {
                    Commited = item.Commited,
                    Depdetailsid = item.Depdetailsid,
                    Itemid = item.Itemid,
                    ProwId = item.ProwId,
                    Unitid = item.Unitid,
                    Unitprice = item.Unitprice,

                };
                if (storeTransDepDetails != null)
                {
                    repo._StoreTrnsDepDetails.Create(storeTransDepDetails);

                }

            }

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
            if (storeTransMId != default)
            {
                STM_VM.StoreTransMaster_VM = repo._StoreTrnsM.RetriveMasterTransactionById(storeTransMId);
                STM_VM.StoreTransMaster_VM.From_Type = repo._Groupf.GetAllTypes(STM_VM.StoreTransMaster_VM.TrnsCode, "F");
                STM_VM.StoreTransMaster_VM.To_Type = repo._Groupf.GetAllTypes(STM_VM.StoreTransMaster_VM.TrnsCode, "T");
                STM_VM.StoreTransMaster_VM.StoreTransMax = repo._StoreTrnsM.GetMaxID(STM_VM.StoreTransMaster_VM.TrnsCode, 2, STM_VM.StoreTransMaster_VM.BranchId);
                STM_VM.StoreTransDetails_VM = repo._StoreTrnsO.RetriveDetailsTransactionById(storeTransMId);

               
                foreach (var item in STM_VM.StoreTransDetails_VM)
                {
                    int GroupF_Id;
                    var ListOfGroupsF = repo._StoreItems.GetGroupFIDForItem((decimal)item.itemId);
                    Dictionary<string, object> current = (Dictionary<string, object>)ListOfGroupsF.Result.FirstOrDefault();
                        GroupF_Id = int.Parse(current.FirstOrDefault().Value.ToString());
                        item.groupF_Id = GroupF_Id;
                    var ItemList = repo._StoreItems.GetItemsDetails(GroupF_Id);
                    ItemDetails_VM ItemDetails_VM = new ItemDetails_VM();
                    foreach (var itemDetail in ItemList.Result.ToList())
                    {
                        Dictionary<string, object> currentItem = (Dictionary<string, object>)itemDetail;
                        ItemDetails_VM.items_VM.Add(new Items_VM { name = (string)currentItem.Values.Last(), itemId = int.Parse(currentItem.Values.First().ToString()) });
                    }


                    var UniteList = repo._StoreUnits.GetUnitesDetails((decimal)STM_VM.StoreTransDetails_VM.FirstOrDefault().itemId);
                    foreach (var itemUnite in UniteList.Result.ToList())
                    {
                        Dictionary<string, object> currentUnite = (Dictionary<string, object>)itemUnite;
                        ItemDetails_VM.unites_VM.Add(new Unites_VM { name = (string)currentUnite.Values.Last(), uniteId = int.Parse(currentUnite.Values.First().ToString()) });
                    }
                    item.itemDetails_VM = ItemDetails_VM;
                }
                var listOfPrevIds = repo._StoreTrnsDep.RetriveListPrevTransIds(storeTransMId);
                if (listOfPrevIds != null)
                {
                    STM_VM.StoreTransDep_VM = repo._StoreTrnsM.RetriveTransaDepById(listOfPrevIds);
                    //foreach (var id in listOfPrevIds)
                    //{
                    //    var listOfStoreTransDepIds = repo._StoreTrnsDep.RetriveListTransDepIds(id);
                    //    var listOfStoreTransDepDetails = repo._StoreTrnsDepDetails.RetiveDepTransDetails(listOfStoreTransDepIds);
                    //    foreach (var item in listOfStoreTransDepDetails)
                    //    {
                    //        STM_VM.StoreTransDepDetails_VM.Add(item);
                    //    }
                    //}

                }
            }
            return STM_VM;
        }

        [HttpPost]
        [Route("UpdateStoreTrans")]
        public JsonResult UpdateStoreTransaction(StoreTransMain_VM StoreTransMain_VM)
        {
            if (StoreTransMain_VM != null)
            {
                StoreTrnsM StoreTrnsM = new StoreTrnsM()
                {
                    Rem = StoreTransMain_VM.StoreTransMaster_VM.Rem,
                    BranchId = StoreTransMain_VM.StoreTransMaster_VM.BranchId,
                    TrnsDate = StoreTransMain_VM.StoreTransMaster_VM.TrnsDate,
                    Storedocnum = StoreTransMain_VM.StoreTransMaster_VM.Storedocnum,
                    FromStoreAllcodesId = StoreTransMain_VM.StoreTransMaster_VM.FromStoreAllcodesId,
                    ToStoreAllcodesId = StoreTransMain_VM.StoreTransMaster_VM.ToStoreAllcodesId,
                    StoreTrnsMId = StoreTransMain_VM.StoreTransMaster_VM.StoreTrnsMId
                };
                repo._StoreTrnsM.Update(StoreTrnsM);
            }
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

        [HttpGet]
        [Route("GetGroupFDetails")]
        public JsonResult GetGroupsDetails()
        {
            List<GroupF_VM> groupF_VMs = new List<GroupF_VM>();
            var GroupsList= repo._Groupf.GetByCondition(c => c.Codetype == 99).Result.Select(n => new { n.GroupfId, n.Aname }).ToList();
            foreach (var item in GroupsList)
            {
                groupF_VMs.Add(new GroupF_VM {Aname= item.Aname,GroupF_Id= (int)item.GroupfId });
            }
            return Json(groupF_VMs, new System.Text.Json.JsonSerializerOptions());
        }
       

        [HttpGet]
        [Route("GetAllGroupsWithItemsDetails")]
        public JsonResult GetAllGroupsWithItemsDetails()
        {
            List<GroupF_VM> groupF_VMs = new List<GroupF_VM>();
            var GroupsList = repo._Groupf.GetByCondition(c => c.Codetype == 99).Result.Select(n => new { n.GroupfId, n.Aname }).ToList();
            foreach (var group in GroupsList)
            {
                //get items for each group
                var ItemList = repo._StoreItems.GetItemsDetails(group.GroupfId);
                List<Items_VM> items_VM = new List<Items_VM>();
                foreach (var item in ItemList.Result.ToList())
                {
                    Dictionary<string, object> current = (Dictionary<string, object>)item;
                    //get unites for each item
                    List<Unites_VM> Unites_VMs = new List<Unites_VM>();
                    var UniteList = repo._StoreUnits.GetUnitesDetails(int.Parse(current.Values.First().ToString()));
                    foreach (var unite in UniteList.Result.ToList())
                    {
                        Dictionary<string, object> currentunite = (Dictionary<string, object>)unite;
                        Unites_VMs.Add(new Unites_VM { name = (string)currentunite.Values.Last(), uniteId = int.Parse(currentunite.Values.First().ToString()) });
                    }
                    items_VM.Add(new Items_VM { name = (string)current.Values.Last(), itemId = int.Parse(current.Values.First().ToString()), unites_VM = Unites_VMs });
                }
                groupF_VMs.Add(new GroupF_VM { Aname = group.Aname, GroupF_Id = (int)group.GroupfId, items_VM = items_VM });
            }
            return Json(groupF_VMs, new System.Text.Json.JsonSerializerOptions());
        }

        [HttpGet]
        [Route("GetItemsDetails")]
        public JsonResult GetItemsDetails(decimal GroupF_Id)
        {
            var ItemList = repo._StoreItems.GetItemsDetails(GroupF_Id);
            ItemDetails_VM ItemDetails_VM = new ItemDetails_VM();
            foreach (var item in ItemList.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                ItemDetails_VM.items_VM.Add(new Items_VM { name = (string)current.Values.Last(), itemId = int.Parse(current.Values.First().ToString()) });
            }

    
            var UniteList= repo._StoreUnits.GetUnitesDetails(ItemDetails_VM.items_VM.FirstOrDefault().itemId);
            foreach (var item in UniteList.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                ItemDetails_VM.unites_VM.Add(new Unites_VM { name = (string)current.Values.Last(), uniteId = int.Parse(current.Values.First().ToString()) });
            }
            //int price;

            //int.TryParse(repo._StoreItems.GetByCondition(c => c.StoreItemsId == ItemDetails_VM.Items_VMs.FirstOrDefault().ItemId).Result.Select(s => new { s.BranchPrice }).FirstOrDefault().BranchPrice.ToString(), out price);

           //var Price=repo._StoreItems.GetByCondition(c => c.StoreItemsId == ItemDetails_VM.Items_VMs.FirstOrDefault().ItemId).Result.Select(s => new { s.BranchPrice}).FirstOrDefault().BranchPrice.ToString();
            return Json(ItemDetails_VM, new System.Text.Json.JsonSerializerOptions());
        }
        [HttpGet]
        [Route("GetUnitesDetails")]
        public JsonResult GetUnitesDetails(decimal storeItemId)
        {
            List<Unites_VM> Unites_VMs = new List<Unites_VM> ();
            var UniteList = repo._StoreUnits.GetUnitesDetails(storeItemId);
            foreach (var item in UniteList.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                Unites_VMs .Add(new Unites_VM { name = (string)current.Values.Last(), uniteId = int.Parse(current.Values.First().ToString()) });
            }
            return Json(Unites_VMs, new System.Text.Json.JsonSerializerOptions());
        }

      }
}
