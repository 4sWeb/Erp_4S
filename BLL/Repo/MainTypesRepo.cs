using BLL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class MainTypesRepo:Base_Repo<MainType>, IMainTypes
    {
        private StoreAllcodesRepo storeAllcodesRepo;
        private GroupfRepo groupfRepo;

        public MainTypesRepo(ModelContext dbContext4S):base(dbContext4S)
        {
            storeAllcodesRepo = new StoreAllcodesRepo(dbContext4S);
            groupfRepo = new GroupfRepo(dbContext4S);
        }

        public MainType GetMainTypeById(decimal? id)
        {
            if (id != null && id != default)
                return GetByCondition(M => M.Id == id).Result.FirstOrDefault();
            return null;
        }

        public string GetNameFromMAinType(decimal? id)
        {
            if(id != null && id != default)
            {
                var GroupfId = storeAllcodesRepo.GetStoreAllCodeById(id) != null ? storeAllcodesRepo.GetStoreAllCodeById(id).GroupfId : null;
                if (GroupfId != null)
                {
                    decimal? MainTypeId = groupfRepo.GetGroupFById(GroupfId) != null ? groupfRepo.GetGroupFById(GroupfId).Codetype : null;
                    if (MainTypeId != null)
                        return GetMainTypeById(MainTypeId).Aname;
                }
            }
            return null;
        }

        public List<MainType> ListMainTypeById(List<decimal?> ids)
        {
            if (ids.Count > 0 && ids != null)
                return GetByCondition(M => ids.Contains(M.Id)).Result;
            return null;
        }
    }
}
