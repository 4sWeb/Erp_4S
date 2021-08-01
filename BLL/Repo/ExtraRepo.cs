using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class ExtraRepo:Base_Repo<Extra>,IExtra
    {
        private ModelContext _dbContext4S;
        private RepoWrapper repo;

        public ExtraRepo(ModelContext dbContext4S) : base(dbContext4S)
        {
            _dbContext4S = dbContext4S;
        }

        public object GetExtraByTrnsID(decimal id)
        {
            repo = new RepoWrapper(_dbContext4S);
            string query = @"Select TRNSEXTRAS.ID as ID , EXTRA.NAME as Name , EXTRA.EXTDTTXT as ExtraType
                                from STORETRNSEXTRAS TrnsExtras
                                inner Join Extras Extra on TRNSEXTRAS.EXTRASFIELDID = EXTRA.ID
                                where TRNSEXTRAS.TRANSID = " + id + "  ";
            var Result = repo.CallQuery(query, null, 0).Result;
            return Result;
        }
    }
}
