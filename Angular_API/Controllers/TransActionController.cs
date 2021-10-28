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
            var cc = TestQuery.Get<StoreTransDep_VM>("select * from STORE_TRNS_DEP");
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
        public JsonResult TransactionSpecByID(decimal transCode, decimal userId,decimal Period=2)
        {
            var TransactionSpec = repo._StoreTrns.GetTransactionSpecsById(transCode);
            if (TransactionSpec.SalesRep!=0) 
            {
                TransactionSpec.Sales_Rep_VM= repo._StoreAllcodes.GetAllSalesRep(7);
                
            }
            var listOfBranches = repo._branch.GetAllBranches(userId);
            List<Branches_VM> branches_VMs = new List<Branches_VM>();
            foreach (var item in listOfBranches.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                branches_VMs.Add(new Branches_VM { BRANCH_ID = int.Parse(current.Values.First().ToString()), NAME = current.Values.Last().ToString() });
            }
            TransactionSpec.TransactionMasterSpec_VM.Branches = branches_VMs;

            //var branches = listOfBranches.Result.FirstOrDefault();
            //Dictionary<string, object> currently = (Dictionary<string, object>)branches;
            //var brancheId = int.Parse(currently.FirstOrDefault().Value.ToString());
            TransactionSpec.StoreTransMax = repo._StoreTrnsM.GetMaxID(transCode, Period);//(branchId)

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
            if (TransactionSpec.TransactionDepSpec_VM.TransactionsNames.Count > 0)
            {
                Items = repo._StoreTrnsM.AllTransByDepID(TransactionSpec.TransactionDepSpec_VM.TransactionsNames.FirstOrDefault().Transaction_Id);
                TransactionSpec.TransactionDepSpec_VM.TrnsList = Items;
            }

            return Json(TransactionSpec, new System.Text.Json.JsonSerializerOptions());
        }



        [HttpGet]
        [Route("TransactionDepSpec")]
        public JsonResult TransactionDepSpec(decimal StoreDepSpecID)
        { 
           var StoreDepSpecDetails_VM= repo._StoreDepSpecsDetails.GetSpecificationForStoreDep(StoreDepSpecID);

            return Json(StoreDepSpecDetails_VM, new System.Text.Json.JsonSerializerOptions());
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
        public JsonResult DisplayItems([FromBody] ProductSpecification_VM productSpecification_VM)
        {
            //List<decimal> Items = new List<decimal>() { 2872, 2878 };
            List<StoreTransDetails_VM> Results = repo._StoreTrnsO.GetTransactionsDetailsList(productSpecification_VM.SelectedStoreTransMIds, productSpecification_VM.Getitems);
            if (Results != null)
            {
                foreach (var item in Results)
                {
                    var ListOfGroupsF = repo._StoreItems.GetGroupFIDForItem((decimal)item.itemId);
                    Dictionary<string, object> current = (Dictionary<string, object>)ListOfGroupsF.Result.FirstOrDefault();
                    item.groupF_Id = int.Parse(current.FirstOrDefault().Value.ToString());
                    string GroupF_Name;
                    var ListOfGroupsFName = repo._StoreItems.GetGroupFNameForItem(item.groupF_Id);
                    Dictionary<string, object> currentName = (Dictionary<string, object>)ListOfGroupsFName.Result.FirstOrDefault();
                    GroupF_Name = currentName.FirstOrDefault().Value.ToString();
                    item.groupF_Name = GroupF_Name;

                }
                Results = repo._StoreTrnsO.CalculatePriceForDepDetailsProduct(Results, productSpecification_VM.DepPricType);
            }
            return Json(Results, new System.Text.Json.JsonSerializerOptions());
        }



        [HttpPost]
        [Route("SaveOrder")]
        public JsonResult SaveOrder([FromBody] StoreTransMain_VM StoreTransMain_VM)
        {
            var enstorTransM = repo._StoreTrnsM.GetByCondition(a => a.StoreTrnsMId == StoreTransMain_VM.StoreTransMaster_VM.StoreTrnsMId).Result.FirstOrDefault();
            if (enstorTransM != null)
            {
                try
                {
                    repo.CallQuery("delete STORE_TRNS_M where STORE_TRNS_M_ID= " + StoreTransMain_VM.StoreTransMaster_VM.StoreTrnsMId + " ", null, 2);
                }
                catch (Exception ex) { }
            }

            var GetNext = (Dictionary<string, object>)repo.CallQuery("select STORE_TRNS_M_SEQ.NEXTVAL from dual").Result.FirstOrDefault();
            object NextValue = GetNext.GetValueOrDefault("NEXTVAL");


            var GetNextO = (Dictionary<string, object>)repo.CallQuery("SELECT STORE_TRNS_o_SEQ.NEXTVAL FROM dual").Result.FirstOrDefault();
            object NextValueO = GetNextO.GetValueOrDefault("NEXTVAL");


            var GetNextD = (Dictionary<string, object>)repo.CallQuery("SELECT STORE_TRNS_DEP_SEQ.NEXTVAL FROM dual").Result.FirstOrDefault();
            object NextValueD = GetNextD.GetValueOrDefault("NEXTVAL");

            var GetNextDt = (Dictionary<string, object>)repo.CallQuery("SELECT STORE_TRNS_DEP_DETAILS_SEQ.NEXTVAL FROM dual").Result.FirstOrDefault();
            object NextValueDt = GetNextDt.GetValueOrDefault("NEXTVAL");


            //ModelState //1

            //       

            //StoreTrnsMID
            StoreTrnsM StoreTrnsM = new StoreTrnsM()
            {
                TrnsCode = StoreTransMain_VM.StoreTransMaster_VM.TrnsCode,
                Rem = StoreTransMain_VM.StoreTransMaster_VM.Rem,
                TrnsNo = StoreTransMain_VM.StoreTransMaster_VM.TrnsNo,
                BranchId = StoreTransMain_VM.StoreTransMaster_VM.BranchId,
                TrnsDate = StoreTransMain_VM.StoreTransMaster_VM.TrnsDate,
                Storedocnum = StoreTransMain_VM.StoreTransMaster_VM.Storedocnum,
                FromStoreAllcodesId =string.IsNullOrEmpty( StoreTransMain_VM.StoreTransMaster_VM.FromStoreAllcodesId.ToString())?null: StoreTransMain_VM.StoreTransMaster_VM.FromStoreAllcodesId,
                ToStoreAllcodesId = string.IsNullOrEmpty(StoreTransMain_VM.StoreTransMaster_VM.ToStoreAllcodesId.ToString())?null: StoreTransMain_VM.StoreTransMaster_VM.ToStoreAllcodesId,
                Period = StoreTransMain_VM.StoreTransMaster_VM.Period,
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
                MainCostcenterid = StoreTransMain_VM.StoreTransMaster_VM.MainCostcenterid,
                Salesrep= StoreTransMain_VM.StoreTransMaster_VM.Salesrep
            };
            repo._StoreTrnsM.Create(StoreTrnsM);
            repo.Save();



            //Add StoreTransDetails
            foreach (var item in StoreTransMain_VM.StoreTransDetails_VM)
            {

                //Check Incoming Obj(item)
                StoreTrnsO StoreTrnsO = new StoreTrnsO
                {
                    
                    Qty = item.qty,
                    UnitId = item.unitId,
                    UnitPrice = item.unitPrice,
                    Notes = item.notes,
                    ItemId = item.itemId,
                    Itemapproved = item.itemapproved,
                    StoretrnsProformlaId = item.storetrnsProformlaId,
                    Totalo = item.totalo,
                    Weekno = item.weekno,
                    StoreTrnsMId = decimal.Parse(NextValue.ToString()) + 1,
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
           
            
            var _StoreTrnsDepId = decimal.Parse(NextValueD.ToString()) + 1;

            if (StoreTransMain_VM.IsDependant) {

                var _Depdetailsid = decimal.Parse(NextValueDt.ToString()) + 1;
                foreach (var item in StoreTransMain_VM.StoreTransDep_VM)
            {
                StoreTrnsDep storeTrnsDep = new StoreTrnsDep()
                {
                    Ptransrowid = item.Ptransrowid,
                    Groupid = item.Groupid,
                    Commited = item.Commited,
                    Depslot = item.Depslot,
                    Depdetailsid = item.Depdetailsid,
                    StoreTrnsDepId = _StoreTrnsDepId++,//decimal.Parse(NextValueD.ToString())+1
                    Ctrnsrowid = decimal.Parse(NextValue.ToString()) + 1, //StoreTransMain_VM.StoreTransDep_VM.FirstOrDefault().Ctrnsrowid,
                    
                    
                };
                        if (storeTrnsDep != null)
                        {
                            repo._StoreTrnsDep.Create(storeTrnsDep);
                        }
                      
                        foreach (var stdepd in StoreTransMain_VM.StoreTransDepDetails_VM)
                        {
                            StoreTrnsDepDetail storeTransDepDetails = new StoreTrnsDepDetail()
                            {
                                Commited = stdepd.Commited,
                                Depdetailsid = _Depdetailsid++, //decimal.Parse(NextValueDt.ToString())+1
                                Itemid = stdepd.Itemid,
                                ProwId = decimal.Parse(NextValueD.ToString()) + 1,
                                Ctrnsorowid= decimal.Parse(NextValueO.ToString()) + 1,
                                Unitid = stdepd.Unitid,
                                Unitprice = stdepd.Unitprice,
                                Quantity=stdepd.Quantity

                            };
                            if (storeTransDepDetails != null)
                            {
                                repo._StoreTrnsDepDetails.Create(storeTransDepDetails);

                            }

                        }
            }
            }
           

            try
            {
                repo.Save();
                //var enstorTransM = repo._StoreTrnsM.GetByCondition(a => a.StoreTrnsMId == StoreTransMain_VM.StoreTransMaster_VM.StoreTrnsMId).Result.FirstOrDefault();
                //if (enstorTransM != null)
                //{
                //    try
                //    {
                //        repo.CallQuery("delete STORE_TRNS_M where STORE_TRNS_M_ID= " + StoreTransMain_VM.StoreTransMaster_VM.StoreTrnsMId + " ", null, 2);
                //    }
                //    catch (Exception ex) { }
                //}
            }
            catch (Exception ex)
            {
                return Json(new { ID = "-1", Result = "Bad Request" }, new System.Text.Json.JsonSerializerOptions());
            }

            return Json(new { ID = "200", Result = "Ok" }, new System.Text.Json.JsonSerializerOptions());
        }


        [HttpGet]
        [Route("deleteOrder")]
        public JsonResult deleteOrder(decimal trnsID) {
            var enstorTransM = repo._StoreTrnsM.GetByCondition(a=>a.StoreTrnsMId==trnsID).Result.FirstOrDefault();
            if (enstorTransM!=null) {
                try 
                {
                    repo.CallQuery("delete STORE_TRNS_M where STORE_TRNS_M_ID= " + trnsID + " ", null, 2);
                }
                catch (Exception ex) { }
            }

            
            try 
            {
                //repo.Save();
            }

            catch (Exception ex){ return Json(new { ID = "-1", Result = "Bad Request" }, new System.Text.Json.JsonSerializerOptions()); }

            return Json(new { ID = "200", Result = "Ok Deleted Successfuly.." }, new System.Text.Json.JsonSerializerOptions());

        }

        [HttpGet]
        [Route("Retrieve")]
        public JsonResult Retrive(decimal storeTransMId)
        {
            StoreTransMain_VM STM_VM = new StoreTransMain_VM();
            STM_VM.IsDependant = false;
            if (storeTransMId != default)
            {
                STM_VM.StoreTransMaster_VM = repo._StoreTrnsM.RetriveMasterTransactionById(storeTransMId);
                if (STM_VM.StoreTransMaster_VM == null)
                {
                    return Json (new {Id="-1",Result="not found" } , new System.Text.Json.JsonSerializerOptions());
                }
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

                    string GroupF_Name;
                    var ListOfGroupsFName = repo._StoreItems.GetGroupFNameForItem(item.groupF_Id);
                    Dictionary<string, object> currentName = (Dictionary<string, object>)ListOfGroupsFName.Result.FirstOrDefault();
                    GroupF_Name = currentName.FirstOrDefault().Value.ToString();
                    item.groupF_Name = GroupF_Name;
                }
                var listOfPrevIds = repo._StoreTrnsDep.RetriveListPrevTransIds(storeTransMId);
               
                if (listOfPrevIds.Count >0)
                {
                    STM_VM.IsDependant = true;
                    STM_VM.StoreTransDep_VM = repo._StoreTrnsM.RetriveTransaDepById(listOfPrevIds);

                    foreach (var id in listOfPrevIds)
                    {
                        var listOfStoreTransDepIds = repo._StoreTrnsDep.RetriveListTransDepIds(id, storeTransMId);
                        var listOfStoreTransDepDetails = repo._StoreTrnsDepDetails.RetiveDepTransDetails(listOfStoreTransDepIds);
                        foreach (var item in listOfStoreTransDepDetails)
                        {
                            STM_VM.StoreTransDepDetails_VM.Add(item);
                        }
                    }

                }  
               
            }
            return Json(STM_VM, new System.Text.Json.JsonSerializerOptions());
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
            var GroupsList = repo._Groupf.GetByCondition(c => c.Codetype == 99).Result.Select(n => new { n.GroupfId, n.Aname }).ToList();
            foreach (var item in GroupsList)
            {
                groupF_VMs.Add(new GroupF_VM { Aname = item.Aname, GroupF_Id = (int)item.GroupfId });
            }
            return Json(groupF_VMs, new System.Text.Json.JsonSerializerOptions());
        }


        [HttpGet]
        [Route("GetAllGroupsWithItemsDetails")]
        public JsonResult GetAllGroupsWithItemsDetails(decimal PeriodId=1)
        {
            //List<GroupItemsUnits_VM> GroupItemsUnits_VM = new List<GroupItemsUnits_VM>();

            //VM=>GROUP_ID GROUP_NAME ITEM_ID ITEM_CODE ITEM_NAME UNIT_ID UNIT_NAME
            string GroupItemsUnitsQuery = @"SELECT GF.GROUPF_ID AS GROUP_ID,
                                            GF.ANAME GROUP_NAME,
                                            SI.STORE_ITEMS_ID AS ITEM_ID,
                                            SI.ITEM_CODE AS ITEM_CODE,
                                            SI.ANAME AS ITEM_NAME,
                                            SU.UNITID AS UNIT_ID,
                                            SU.ANAME AS UNIT_NAME, 
                                            --NVL(SIFU.UNITID,0.00) + 0 AS BASIC_UNIT
                                            NVL(SIU.UNIT_RATE,1) AS UNIT_RATE,
                                            NVL( (SELECT SIFU2.UNITID FROM STORE_ITEM_UNITS SIFU2 WHERE  SIFU2.STORE_ITEMS_ID= SI.STORE_ITEMS_ID  AND SIFU2.BASIC_UNIT=1),0.00) + 0 AS BASIC_UNIT
                                            ,NVL(SIP.IPURCHPRICE,0) AS PURCH_PRICE , 
                                            NVL(SI.SALE_PRICE,0) AS SALES_PRICE , 
                                            NVL(SI.DEAL_PRICE,0) AS DEAL_PRICE, 
                                            NVL(SI.BRANCH_PRICE,0) AS BRANCH_PRICE , 
                                            NVL(SI.RETAIL_PRICE,0) AS RETAIL_PRICE
                                       FROM STORE_ITEMS SI
                                            LEFT JOIN STORE_ITEM_UNITS SIU
                                               ON SIU.STORE_ITEMS_ID = SI.STORE_ITEMS_ID
                                            LEFT JOIN STORE_UNITS SU
                                               ON SU.UNITID = SIU.UNITID
                                            LEFT JOIN STORE_ITEMFORMS_SPECS SIFS
                                               ON SIFS.STORE_ITEMFROMS_SPECS_ID = SI.STORE_ITEMFROMS_SPECS_ID
                                            LEFT JOIN STORE_ITEMFORM_UNITS SIFU
                                               ON SIFU.UNITID = SU.UNITID
                                                  AND SIFU.STORE_ITEMFORM_SPECS_ID =
                                                         SIFS.STORE_ITEMFROMS_SPECS_ID
                                            LEFT JOIN GROUPF GF
                                               ON GF.GROUPF_ID = SIFS.GROUPF_ID
                                            LEFT JOIN MAIN_TYPES MT
                                               ON MT.ID = GF.CODETYPE
                                            LEFT JOIN STORE_ITEM_PRICE SIP 
                                               ON SIP.ITEMID=SI.STORE_ITEMS_ID  AND SIP.PERIOD= " + PeriodId +
                                               " ORDER BY GF.GROUPF_ID, SI.ITEM_CODE, SU.UNITID";

            var GroupItemsUnits_VM = repo.CallQuery<GroupItemsUnits_VM>(GroupItemsUnitsQuery).Result.ToList();



            //List<GroupF_VM> groupF_VMs = new List<GroupF_VM>();
            //var GroupsList = repo._Groupf.GetByCondition(c => c.Codetype == 99).Result.Select(n => new { n.GroupfId, n.Aname }).ToList();
            //foreach (var group in GroupsList)
            //{
            //    //get items for each group
            //    var ItemList = repo._StoreItems.GetItemsDetails(group.GroupfId);
            //    List<Items_VM> items_VM = new List<Items_VM>();
            //    foreach (var item in ItemList.Result.ToList())
            //    {
            //        Dictionary<string, object> current = (Dictionary<string, object>)item;
            //        //get unites for each item
            //        List<Unites_VM> Unites_VMs = new List<Unites_VM>();
            //        var UniteList = repo._StoreUnits.GetUnitesDetails(int.Parse(current.Values.First().ToString()));
            //        foreach (var unite in UniteList.Result.ToList())
            //        {
            //            Dictionary<string, object> currentunite = (Dictionary<string, object>)unite;
            //            Unites_VMs.Add(new Unites_VM { name = (string)currentunite.Values.Last(), uniteId = int.Parse(currentunite.Values.First().ToString()) });
            //        }
            //        items_VM.Add(new Items_VM { name = (string)current.Values.Last(), itemId = int.Parse(current.Values.First().ToString()), unites_VM = Unites_VMs });
            //    }
            //    groupF_VMs.Add(new GroupF_VM { Aname = group.Aname, GroupF_Id = (int)group.GroupfId, items_VM = items_VM });
            //}
            return Json(GroupItemsUnits_VM, new System.Text.Json.JsonSerializerOptions());
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


            var UniteList = repo._StoreUnits.GetUnitesDetails(ItemDetails_VM.items_VM.FirstOrDefault().itemId);
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
            List<Unites_VM> Unites_VMs = new List<Unites_VM>();
            var UniteList = repo._StoreUnits.GetUnitesDetails(storeItemId);
            foreach (var item in UniteList.Result.ToList())
            {
                Dictionary<string, object> current = (Dictionary<string, object>)item;
                Unites_VMs.Add(new Unites_VM { name = (string)current.Values.Last(), uniteId = int.Parse(current.Values.First().ToString()) });
            }
            return Json(Unites_VMs, new System.Text.Json.JsonSerializerOptions());
        }


        [HttpGet]
        [Route("GetItemsWithAndBalance")]
        public JsonResult GetItemsWithAndBalance()
        {
            string GroupItemsBalanceQuery = @"SELECT T.CODE AS STORE_ID , T.ANAME AS STORE_NAME , T.ITEM_ID AS ITEM_ID , SUM(QTY) AS QTY 
                                        FROM( 
                                            SELECT SAC.STORE_ALLCODES_ID AS CODE, SAC.ANAME AS ANAME, SI.STORE_ITEMS_ID AS ITEM_ID
                                            , SIB.I_QTY * (SELECT SIFU2.UNIT_RATE FROM STORE_ITEM_UNITS SIFU2 WHERE  SIFU2.STORE_ITEMS_ID = SI.STORE_ITEMS_ID AND SIFU2.UNITID = SIB.UNIT_ID) AS QTY
                                             FROM STORE_ITEMS SI
                                             INNER JOIN STORE_ITEMS_BAL SIB ON SI.STORE_ITEMS_ID = SIB.STORE_ITEMS_ID
                                             INNER JOIN STORE_ALLCODES SAC ON SAC.STORE_ALLCODES_ID = SIB.STORE_ALLCODES_ID
                                             INNER JOIN GROUPF GF ON GF.GROUPF_ID = SAC.GROUPF_ID
                                             INNER JOIN MAIN_TYPES MT ON MT.ID = GF.CODETYPE
                                             WHERE MT.ID = 4 AND SIB.PERIOD = 2
                                             UNION ALL
                                             SELECT SAC.STORE_ALLCODES_ID AS CODE,SAC.ANAME AS ANAME
                                             ,STO.ITEM_ID AS ITEM_ID ,STO.QTY * (SELECT SIFU2.UNIT_RATE FROM STORE_ITEM_UNITS SIFU2 WHERE SIFU2.STORE_ITEMS_ID = STO.ITEM_ID AND SIFU2.UNITID = STO.UNIT_ID) AS QTY
                                             FROM STORE_TRNS_O STO
                                             INNER JOIN STORE_TRNS_M STM ON STO.STORE_TRNS_M_ID = STM.STORE_TRNS_M_ID
                                             INNER JOIN STORE_ALLCODES SAC ON SAC.STORE_ALLCODES_ID = STM.TO_STORE_ALLCODES_ID
                                             INNER JOIN GROUPF GF ON GF.GROUPF_ID = SAC.GROUPF_ID
                                             INNER JOIN MAIN_TYPES MT ON MT.ID = GF.CODETYPE
                                             WHERE MT.ID = 4 AND STM.PERIOD = 2 AND STM.COMMITED = 1
                                             UNION ALL
                                             SELECT SAC.STORE_ALLCODES_ID AS CODE,SAC.ANAME AS ANAME
                                             ,STO.ITEM_ID AS ITEM_ID , (STO.QTY * -1) * (SELECT SIFU2.UNIT_RATE FROM STORE_ITEM_UNITS SIFU2 WHERE SIFU2.STORE_ITEMS_ID = STO.ITEM_ID AND SIFU2.UNITID = STO.UNIT_ID) AS QTY
                                             FROM STORE_TRNS_O STO
                                             INNER JOIN STORE_TRNS_M STM ON STO.STORE_TRNS_M_ID = STM.STORE_TRNS_M_ID
                                             INNER JOIN STORE_ALLCODES SAC ON SAC.STORE_ALLCODES_ID = STM.FROM_STORE_ALLCODES_ID
                                             INNER JOIN GROUPF GF ON GF.GROUPF_ID = SAC.GROUPF_ID
                                             INNER JOIN MAIN_TYPES MT ON MT.ID = GF.CODETYPE
                                             WHERE MT.ID = 4 AND STM.PERIOD = 2 AND STM.COMMITED = 1
                                             ) T
                                             GROUP BY T.CODE  , T.ANAME  , T.ITEM_ID
                                             ORDER BY T.ITEM_ID, STORE_ID";
            var ItemsWithBalance_VM = repo.CallQuery<ItemsWithBalance_VM>(GroupItemsBalanceQuery).Result.ToList();

            return Json(ItemsWithBalance_VM, new System.Text.Json.JsonSerializerOptions());
        }


    }
}
