using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class GroupfRepo:Base_Repo<Groupf>,IGroupf
    {
        private ModelContext _dbContext4S;
        private RepoWrapper repo;

        public GroupfRepo(ModelContext dbContext4S):base(dbContext4S)
        {
            _dbContext4S = dbContext4S;
        }

        public Groupf GetGroupFById(decimal? id)
        {
            if (id != null && id != default)
                return GetByCondition(G => G.GroupfId == id).Result.FirstOrDefault();
            return null;
        }


        public object GetAllTypes(decimal Id , string type)
        {
            repo = new RepoWrapper(_dbContext4S);

            string query = @"select GF.GROUPF_ID as Type_ID , GF.ANAME as Type_Name
                            from STOREDSTTYPEs dst
                            inner
                            join Main_TYPES MType on DST.DSTTYPE = MTYPE.ID
                            inner Join GroupF gf on GF.CODETYPE = MTYPE.ID
                            where DST.FT in '" + type + "' and DST.TRNSCODE = " + Id + " ";
            var ResQuery = repo.CallQuery(query, null, 0).Result;
            return ResQuery;
        }

    }
}
