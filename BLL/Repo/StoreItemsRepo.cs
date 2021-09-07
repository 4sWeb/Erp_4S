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
        //alzahraa 4/8/2021 trying to retrive list of To Items
        //getItemsDetails
        public object GetItemsDetails(decimal Id)
        {

            string query = @"select STORE_ITEMS.ITEM_CODE as ItemId , STORE_ITEMS.ANAME as ItemName
                            from STORE_ITEMS 
                            inner Join STORE_ITEMFORMS_SPECS  on STORE_ITEMS.STORE_ITEMFROMS_SPECS_ID = STORE_ITEMFORMS_SPECS.STORE_ITEMFROMS_SPECS_ID
                            where STORE_ITEMFORMS_SPECS.GROUPF_ID = " + Id + " ";
            var ResQuery = testQuery.Get(query, null, 0);
            return ResQuery;
        }
    }
}
