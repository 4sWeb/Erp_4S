using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class BranchRepo : Base_Repo<Branch1> , IBranch
    {
        TestQuery testQuery = new TestQuery();
        public BranchRepo(ModelContext dbContext4S) : base(dbContext4S)
        {


        }
        public Task<List< object>> GetAllBranches(decimal Id) {


            string query = @"select BRANCHES.BRANCHID as Branch_ID , STORE_ALLSUBCODES.ANAME as Name
                            from BRANCHES 
                            inner
                            join STORE_ALLSUBCODES  on BRANCHES.BRANCHID = STORE_ALLSUBCODES.STORE_ALLSUBCODES_ID 
                            where STORE_ALLSUBCODES.CODETYPE =999 and BRANCHES.USERID =" + Id+"";
            var ResQuery = testQuery.Get(query, null, 0);
            return ResQuery;

        }

    }
}
