using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class StoreUnitsRepo:Base_Repo<StoreUnit>, IStoreUnits
    {
        TestQuery testQuery = new TestQuery();
        public StoreUnitsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
        public Task<List<object>> GetUnitesDetails(decimal storeItemId)
        {
            string query = @"select STORE_UNITS.UNITID as UniteId , STORE_UNITS.ANAME as UniteName
                            from STORE_UNITS 
                            inner Join STORE_ITEM_UNITS  on STORE_ITEM_UNITS.UNITID = STORE_UNITS.UNITID
                            where STORE_ITEM_UNITS.STORE_ITEMS_ID = " + storeItemId + " ";
            var ResQuery = testQuery.Get(query, null, 0);
            return ResQuery;
        }
    }
}
