using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        private StoreTrnsProducationformlaRepo storeMaterial;
        public StoreTrnsORepo(ModelContext dbContext4S) : base(dbContext4S)
        {
            context = dbContext4S;
        }

        public List<StoreTransDetails_VM> GetTransactionsDetailsList(List<decimal> TransactionsList,decimal Getitems)
        {
            SItems = new StoreItemsRepo(context);
            SUnit = new StoreUnitsRepo(context);
            List<StoreTransDetails_VM> ItemsList = new List<StoreTransDetails_VM>();
            Expression<Func<StoreTrnsO, bool>> expression = null;
           
                foreach (var item in TransactionsList)
                {
                    if (Getitems == 2)
                    {
                        expression = c => c.StoreTrnsMId == item && c.Itemapproved == true;

                    }
                    else if (Getitems == 3)
                    {
                         expression = c => c.StoreTrnsMId == item && c.Itemapproved == false;
                    }
                    else if (Getitems == 0)
                    {
                         expression = c => c.StoreTrnsMId == item;
                    }
                    else 
                    {
                    return ItemsList;
                    }
                    ItemsList.AddRange(GetByCondition(expression).Result.Select(s => new StoreTransDetails_VM
                    {
                        itemId = s.ItemId,
                        item_Name = SItems.GetByCondition(c => c.StoreItemsId == s.ItemId).Result.FirstOrDefault().Aname,
                        qty = s.Qty,
                        unitPrice = string.IsNullOrEmpty(s.UnitPrice.ToString()) ? 0 : (decimal)s.UnitPrice,
                        //price = string.IsNullOrEmpty(s.UnitPrice.ToString()) ? 0 : (decimal)s.UnitPrice,
                        totalo = string.IsNullOrEmpty(s.Totalo.ToString()) ? 0 : (decimal)s.Totalo,
                        disc_Rate = string.IsNullOrEmpty(s.DiscRate.ToString()) ? 0 : s.DiscRate,
                        disc_Value = string.IsNullOrEmpty(s.DiscVal.ToString()) ? 0 : s.DiscVal,
                        item2nddiscVal= string.IsNullOrEmpty(s.Item2nddiscVal.ToString()) ? 0 : s.Item2nddiscVal,
                        stax_Rate = 0,
                        stax_Value = string.IsNullOrEmpty(s.StaxVal.ToString()) ? 0 : s.StaxVal,
                        unit2ndprice = string.IsNullOrEmpty(s.Unit2ndprice.ToString()) ? 0 : s.Unit2ndprice,
                        profit_Tax_Rate = 0,
                        profit_Tax_Value = 0,
                        net_Value = string.IsNullOrEmpty(s.Totalo.ToString()) ? 0 : (decimal)s.Totalo,
                        notes = string.IsNullOrEmpty(s.Notes) ? " " : s.Notes,
                        store_Trns_M_ID = (decimal)s.StoreTrnsMId,
                        storeTrnsOId = s.StoreTrnsOId,
                        unitId = s.UnitId,
                        unit_Name = SUnit.GetByCondition(c => c.Unitid == s.UnitId).Result.FirstOrDefault().Aname,
                    }).ToList());

                }
          
            return ItemsList;
        }

  

        public List<StoreTransDetails_VM> CalculatePriceForDepDetailsProduct(List<StoreTransDetails_VM> storeTransDetails_VMs, decimal DepPricetype)
        {
            if (DepPricetype==1)
            {
                foreach (var item in storeTransDetails_VMs)
                {
                    item.price = item.unitPrice - item.disc_Value;
                }

            }
            else if(DepPricetype == 2)
            {
                foreach (var item in storeTransDetails_VMs)
                {
                    item.price = item.unitPrice -(item.staxVal+ item.disc_Value);
                }

            }
            else if (DepPricetype==3)
            {
                foreach (var item in storeTransDetails_VMs)
                {
                    item.price = item.unitPrice + item.unit2ndprice;
                }
                
            }
            return storeTransDetails_VMs;
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
                        item_Name = SItems.GetByCondition(c => c.StoreItemsId == item.ItemId).Result.FirstOrDefault().ItemCode .PadRight (10)+
                                    SItems.GetByCondition(c => c.StoreItemsId == item.ItemId).Result.FirstOrDefault().Aname,
                        
                    });
                }
                return ItemsList;
            }
                return null;
        }




        public List<StoreTrnsDepDetailsMaterial_VM> GetTransactionsDetailsListWithMaterial(List<decimal> TransactionsList, decimal Getitems)
        {
            SItems = new StoreItemsRepo(context);
            SUnit = new StoreUnitsRepo(context);
            List<StoreTrnsDepDetailsMaterial_VM> ItemsList = new List<StoreTrnsDepDetailsMaterial_VM>();
            if (Getitems == 4)
            {
                foreach (var item in TransactionsList)
                {
                    ItemsList.AddRange(GetByCondition(c => c.StoreTrnsMId == item).Result.Select(s => new StoreTrnsDepDetailsMaterial_VM
                    {
                        itemId = s.ItemId,
                        item_Name = SItems.GetByCondition(c => c.StoreItemsId == s.ItemId).Result.FirstOrDefault().Aname,
                        qty = s.Qty,
                        unitPrice = string.IsNullOrEmpty(s.UnitPrice.ToString()) ? 0 : (decimal)s.UnitPrice,
                        price = string.IsNullOrEmpty(s.UnitPrice.ToString()) ? 0 : (decimal)s.UnitPrice,
                        totalo = string.IsNullOrEmpty(s.Totalo.ToString()) ? 0 : (decimal)s.Totalo,
                        disc_Rate = string.IsNullOrEmpty(s.DiscRate.ToString()) ? 0 : s.DiscRate,
                        disc_Value = string.IsNullOrEmpty(s.DiscVal.ToString()) ? 0 : s.DiscVal,
                        tax_Rate = 0,
                        tax_Value = string.IsNullOrEmpty(s.StaxVal.ToString()) ? 0 : s.StaxVal,
                        profit_Tax_Rate = 0,
                        profit_Tax_Value = 0,
                        net_Value = string.IsNullOrEmpty(s.Totalo.ToString()) ? 0 : (decimal)s.Totalo,
                        notes = string.IsNullOrEmpty(s.Notes) ? " " : s.Notes,
                        store_Trns_M_ID = (decimal)s.StoreTrnsMId,
                        storeTrnsOId = s.StoreTrnsOId,
                        unitId = s.UnitId,
                        unit_Name = SUnit.GetByCondition(c => c.Unitid == s.UnitId).Result.FirstOrDefault().Aname,
                    }).ToList());

                }
            }
         

            return null;
        }


    }
}
