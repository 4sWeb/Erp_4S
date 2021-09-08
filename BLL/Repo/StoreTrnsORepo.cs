using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsORepo:Base_Repo<StoreTrnsO>, IStoreTrnsO
    {
        private readonly IRepoWrapper repo;
        private StoreItemsRepo SItems;
        private StoreUnitsRepo SUnit;
        private StoreItemformsSpecsRepo storespecForm;
        private GroupfRepo Groupf;
        private ModelContext context;
        public StoreTrnsORepo(ModelContext dbContext4S) : base(dbContext4S)
        {
            context = dbContext4S;
        }

        public List<TransactionsDetails_VM> GetTransactionsDetailsList(List<decimal> TransactionsList)
        {
            SItems = new StoreItemsRepo(context);
            SUnit = new StoreUnitsRepo(context);
            List<TransactionsDetails_VM> ItemsList = new List<TransactionsDetails_VM>();
            foreach (var item in TransactionsList)
            {
                ItemsList.AddRange(GetByCondition(c => c.StoreTrnsMId == item).Result.Select(s => new TransactionsDetails_VM
                {
                    Item_ID = s.ItemId,
                    Item_Name = SItems.GetByCondition(c => c.StoreItemsId == s.ItemId).Result.FirstOrDefault().Aname,
                    Quantity = s.Qty,
                    Price = s.UnitPrice,
                    Value = s.Totalo,
                    Disc_Rate = s.DiscRate,
                    Disc_Value = s.DiscVal,
                    Tax_Rate = 0,
                    Tax_Value = s.StaxVal,
                    Profit_Tax_Rate = 0,
                    Profit_Tax_Value = 0,
                    Net_Value = s.Totalo,
                    Note = s.Notes,
                    Store_Trns_M_ID = s.StoreTrnsMId,
                    StoreTrnsOID = s.StoreTrnsOId,
                    Unit_ID = s.UnitId,
                    Unit_Name = SUnit.GetByCondition(c => c.Unitid == s.UnitId).Result.FirstOrDefault().Aname,
                }).ToList());

            }
            return ItemsList;
        }

        //convert viewmodel to model and add it 
        public void convert_VMtoModel(List<StoreTransDetails_VM> STD_VM)
        {

            foreach (var item in STD_VM)
            {
                StoreTrnsO StoreTrnsO = new StoreTrnsO
                {
                    StoreTrnsOId = item.StoreTrnsOId,
                    Qty = item.Qty,
                    UnitId = item.UnitId,
                    UnitPrice = item.UnitPrice,
                    Notes = item.Notes,
                    ItemId = item.ItemId,
                    Itemapproved = item.Itemapproved,
                    StoretrnsProformlaId = item.StoretrnsProformlaId
                };
                repo._StoreTrnsO.Create(StoreTrnsO);


            }
        }

        //Retrive List of Tranaction  details by id
        public List<StoreTransDetails_VM> RetriveDetailsTransactionById(decimal storeTransMId)
        {
            SItems = new StoreItemsRepo(context);
            SUnit = new StoreUnitsRepo(context);
            storespecForm = new  StoreItemformsSpecsRepo(context);
            List<StoreTransDetails_VM> ItemsList = new List<StoreTransDetails_VM>();
            
            if (storeTransMId != default)
            {

                var list  = GetByCondition(c => c.StoreTrnsMId == storeTransMId).Result.Select(s => new { s.Qty,s.ItemId,s.UnitId,s.StoreTrnsMId,s.Notes,s.Totalo,s.StoreTrnsOId}).ToList();
                foreach (var item in list)
                {
                    ItemsList.Add(new StoreTransDetails_VM { 
                        ItemId=item.ItemId,
                        StoreItemfromsSpecsId = (decimal)SItems.GetByCondition(c => c.StoreItemsId == (decimal)item.ItemId).Result.Select(s => s.StoreItemfromsSpecsId).FirstOrDefault(),
                        //GroupF_Id= storespecForm.GetByCondition(c=>c.StoreItemfromsSpecsId=item.st)
                        Qty =item.Qty,
                        UnitId = item.UnitId,
                        Totalo= (decimal)item.Totalo,
                        StoreTrnsMId = (decimal)item.StoreTrnsMId,
                        StoreTrnsOId=item.StoreTrnsOId,
                        Unit_Name = SUnit.GetByCondition(c => c.Unitid == item.UnitId).Result.FirstOrDefault().Aname,
                        Item_Name = SItems.GetByCondition(c => c.StoreItemsId == item.ItemId).Result.FirstOrDefault().Aname,
                    });
                }
                return ItemsList;
            }
            
            
                return null;
        }
    }
}
