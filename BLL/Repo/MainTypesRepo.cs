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
        private ModelContext _dbContext4S;

        public MainTypesRepo(ModelContext dbContext4S):base(dbContext4S)
        {
            _dbContext4S = dbContext4S;
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
                storeAllcodesRepo = new StoreAllcodesRepo(_dbContext4S);
                groupfRepo = new GroupfRepo(_dbContext4S);

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

        public decimal GetFromIdMAinType(decimal? id)
        {
            if (id != null && id != default)
            {
                storeAllcodesRepo = new StoreAllcodesRepo(_dbContext4S);
                groupfRepo = new GroupfRepo(_dbContext4S);

                var GroupfId = storeAllcodesRepo.GetStoreAllCodeById(id) != null ? storeAllcodesRepo.GetStoreAllCodeById(id).GroupfId : null;
                if (GroupfId != null)
                {
                    decimal? MainTypeId = groupfRepo.GetGroupFById(GroupfId) != null ? groupfRepo.GetGroupFById(GroupfId).Codetype : null;
                    if (MainTypeId != null)
                        return GetMainTypeById(MainTypeId).Id;
                }
            }
            return -1;
        }

    }
}
