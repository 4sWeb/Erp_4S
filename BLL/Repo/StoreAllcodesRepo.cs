using BLL.IRepo;
using BLL.ERPModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class StoreAllcodesRepo:Base_Repo<StoreAllcode>, IStoreAllcodes
    {
        TestQuery testQuery = new TestQuery();
        public StoreAllcodesRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }

        public StoreAllcode GetStoreAllCodeById(decimal? id)
        {
            if (id != null && id != default)
                return GetByCondition(s => s.StoreAllcodesId == id).Result.FirstOrDefault();
            return null;
        }

        //getAllSalesRep
        public List<Sales_Rep_VM> GetAllSalesRep(decimal Id)
        {

            string query = @"select STORE_ALLCODES.STORE_ALLCODES_ID AS Sales_ID ,
                            STORE_ALLCODES.ANAME AS Sales_Name , STORE_ALLCODES.CODE AS Sales_Code
                            from STORE_ALLCODES 
                            join GROUPF  on GROUPF.GROUPF_ID = STORE_ALLCODES.GROUPF_ID
                            Join MAIN_TYPES  on MAIN_TYPES.ID = GROUPF.CODETYPE
                            where MAIN_TYPES.ID = " + Id + " ";
            var ResQuery=TestQuery.Get<Sales_Rep_VM>(query).Result.ToList();
            return ResQuery;
        }

    }
}
