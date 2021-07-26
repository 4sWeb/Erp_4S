using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class GroupfRepo:Base_Repo<Groupf>,IGroupf
    {
        private StoredsttypesRepo storedsttypesRepo;
        private MainTypesRepo mainTypesRepo;
        public GroupfRepo(ModelContext dbContext4S):base(dbContext4S)
        {
            storedsttypesRepo = new StoredsttypesRepo(dbContext4S);
            mainTypesRepo = new MainTypesRepo(dbContext4S);
        }

        public Groupf GetGroupFById(decimal? id)
        {
            if (id != null && id != default)
                return GetByCondition(G => G.GroupfId == id).Result.FirstOrDefault();
            return null;
        }

        public List<Groupf> ListGroupFByCodeType(List<decimal> ids)
        {
            if (ids.Count > 0)
                return GetByCondition(G => ids.Contains(G.Codetype.Value)).Result;
            return null;
        }

        //public List<GroupF_VM> GetTypes(decimal id, string type)
        //{
        //    if(id != default && !string.IsNullOrEmpty(type))
        //    {
        //        var DstTypeList = storedsttypesRepo.ListStoreDstTypeByTransID(id, type)?.Select(s => s.Dsttype).ToList();
        //        if (DstTypeList.Count > 0)
        //        {
        //            var MainTypesIds = mainTypesRepo.ListMainTypeById(DstTypeList)?.Select(M => M.Id);
        //        }
        //    }
        //}

    }
}
