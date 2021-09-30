using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class StoreItemsRepo:Base_Repo<StoreItem>, IStoreItems
    {
        TestQuery testQuery = new TestQuery();
        public StoreItemsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
       
        //getItemsDetails
        public Task<List<object>>  GetItemsDetails(decimal Id)
        {

            string query = @"select STORE_ITEMS.STORE_ITEMS_ID as ItemId , STORE_ITEMS.ANAME as ItemName
                            from STORE_ITEMS 
                            inner Join STORE_ITEMFORMS_SPECS  on STORE_ITEMS.STORE_ITEMFROMS_SPECS_ID = STORE_ITEMFORMS_SPECS.STORE_ITEMFROMS_SPECS_ID
                            where STORE_ITEMFORMS_SPECS.GROUPF_ID = " + Id + " ";
            var ResQuery = testQuery.Get(query, null, 0);
            return ResQuery;
        }

        //Get GroupF_Id For item
        public Task<List<object>> GetGroupFIDForItem(decimal Id)
        {

            string query = @"select STORE_ITEMFORMS_SPECS.GROUPF_ID as GROUPF_ID 
                            from STORE_ITEMS 
                            inner Join STORE_ITEMFORMS_SPECS  on STORE_ITEMFORMS_SPECS.STORE_ITEMFROMS_SPECS_ID = STORE_ITEMS.STORE_ITEMFROMS_SPECS_ID
                            where  STORE_ITEMS.STORE_ITEMS_ID = " + Id + " ";
            var ResQuery = testQuery.Get(query, null, 0);
            return ResQuery;
        }

        //Get GroupF_Name For item
        public Task<List<object>> GetGroupFNameForItem(decimal Id)
        {
            string query = @"select GROUPF.ANAME as ANAME
                            from GROUPF
                            where  GROUPF.GROUPF_ID = " + Id + " ";
            var ResQuery = testQuery.Get(query, null, 0);
            return ResQuery;
        }
    }
}
