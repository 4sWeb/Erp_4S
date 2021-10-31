using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class GroupfRepo:Base_Repo<Groupf>,IGroupf
    {
        TestQuery testQuery = new TestQuery();

        public GroupfRepo(ModelContext dbContext4S):base(dbContext4S)
        {
           
        }

        public Groupf GetGroupFById(decimal? id)
        {
            if (id != null && id != default)
                return GetByCondition(G => G.GroupfId == id).Result.FirstOrDefault();
            return null;
        }


        public object GetAllTypes(decimal Id , string type)
        {

            string query = @"select GF.GROUPF_ID as Type_ID , GF.ANAME as Type_Name,GF.CODETYPE as MAINTYPE_ID
                            from STOREDSTTYPEs dst
                            inner
                            join Main_TYPES MType on DST.DSTTYPE = MTYPE.ID
                            inner Join GroupF gf on GF.CODETYPE = MTYPE.ID
                            where DST.FT in '" + type + "' and DST.TRNSCODE = " + Id + " ";
            var ResQuery = testQuery.Get(query, null, 0).Result;
            return ResQuery;

        }


        //alzahraa 4/8/2021 trying to retrive list of To Type
        //getAllToType
        public Task<List<object>> GetAllToTypes(decimal Id)
        {

            string query = @"select GF.GROUPF_ID as Type_ID , GF.ANAME as Type_Name
                            from STOREDSTTYPEs dst
                            inner
                            join Main_TYPES MType on DST.DSTTYPE = MTYPE.ID
                            inner Join GroupF gf on GF.CODETYPE = MTYPE.ID
                            where DST.FT in 'T' and DST.TRNSCODE = " + Id + " ";
            var ResQuery = testQuery.Get(query, null, 0);
            return ResQuery;
        }


        //getAllFromType
        public Task<List<object>> GetAllFromTypes(decimal Id)
        {

            string query = @"select GF.GROUPF_ID as Type_ID , GF.ANAME as Type_Name
                            from STOREDSTTYPEs dst
                            inner
                            join Main_TYPES MType on DST.DSTTYPE = MTYPE.ID
                            inner Join GroupF gf on GF.CODETYPE = MTYPE.ID
                            where DST.FT in 'F' and DST.TRNSCODE = " + Id + " ";
            var ResQuery = testQuery.Get(query, null, 0);
            return ResQuery;
        }

    }
}
