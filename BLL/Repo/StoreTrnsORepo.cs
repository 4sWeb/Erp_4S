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
        private StoreItemsRepo SItems;
        private StoreUnitsRepo SUnit;
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
    }
}
