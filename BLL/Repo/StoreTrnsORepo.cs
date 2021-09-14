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

        public List<StoreTransDetails_VM> GetTransactionsDetailsList(List<decimal> TransactionsList)
        {
            SItems = new StoreItemsRepo(context);
            SUnit = new StoreUnitsRepo(context);
            List<StoreTransDetails_VM> ItemsList = new List<StoreTransDetails_VM>();
            foreach (var item in TransactionsList)
            {
                ItemsList.AddRange(GetByCondition(c => c.StoreTrnsMId == item).Result.Select(s => new StoreTransDetails_VM
                {
                    itemId = s.ItemId,
                    item_Name = SItems.GetByCondition(c => c.StoreItemsId == s.ItemId).Result.FirstOrDefault().Aname,
                    qty = s.Qty,
                    price = s.UnitPrice,
                    totalo = (decimal)s.Totalo,
                    disc_Rate = s.DiscRate,
                    disc_Value = s.DiscVal,
                    tax_Rate = 0,
                    tax_Value = s.StaxVal,
                    profit_Tax_Rate = 0,
                    profit_Tax_Value = 0,
                    net_Value = (decimal)s.Totalo,
                    notes = s.Notes,
                    store_Trns_M_ID = (decimal)s.StoreTrnsMId,
                    storeTrnsOId = s.StoreTrnsOId,
                    unitId = s.UnitId,
                    unit_Name = SUnit.GetByCondition(c => c.Unitid == s.UnitId).Result.FirstOrDefault().Aname,
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
                    StoreTrnsOId = item.storeTrnsOId,
                    Qty = item.qty,
                    UnitId = item.unitId,
                    UnitPrice = item.unitPrice,
                    Notes = item.notes,
                    ItemId = item.itemId,
                    Itemapproved = item.itemapproved,
                    StoretrnsProformlaId = item.storetrnsProformlaId
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

                var list  = GetByCondition(c => c.StoreTrnsMId == storeTransMId).Result.Select(s => new { s.Qty,s.ItemId,s.UnitId,s.StoreTrnsMId,s.Notes,s.Totalo,s.StoreTrnsOId,s.UnitPrice}).ToList();
                foreach (var item in list)
                {
                    ItemsList.Add(new StoreTransDetails_VM { 
                        itemId=item.ItemId,
                        //GroupF_Id = (decimal)SItems.GetByCondition(c => c.StoreItemsId == (decimal)item.ItemId).Result.Select(s => s.StoreItemfromsSpecs.Select(c=>c.GroupfId).FirstOrDefault()).FirstOrDefault(),
                        //GroupF_Id= storespecForm.GetByCondition(c=>c.StoreItemfromsSpecsId=item.st)
                        qty =item.Qty,
                        unitId = item.UnitId,
                        totalo= (decimal)item.Totalo,
                        storeTrnsMId = (decimal)item.StoreTrnsMId,
                        storeTrnsOId=item.StoreTrnsOId,
                        unitPrice=item.UnitPrice,
                        unit_Name = SUnit.GetByCondition(c => c.Unitid == item.UnitId).Result.FirstOrDefault().Aname,
                        item_Name = SItems.GetByCondition(c => c.StoreItemsId == item.ItemId).Result.FirstOrDefault().Aname,
                    });
                }
                return ItemsList;
            }
                return null;
        }

     
    }
}
