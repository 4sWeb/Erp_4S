using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoreDepSpecsDetailsRepo:Base_Repo<StoreDepSpecsDetail>, IStoreDepSpecsDetails
    {
        public StoreDepSpecsDetailsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }


        public StoreDepSpecDetails_VM GetSpecificationForStoreDep(decimal StoreDepSpecID)
        {
          
            var res = GetByCondition(s => s.GroupId == StoreDepSpecID).Result.Select(n=>new StoreDepSpecDetails_VM 
            {
                DepOnTrnsCode=n.DepOnTrnsCode,
                Depsign = n.Depsign,
                Getitems =n.Getitems,
                CollectItem=n.CollectItem,
                GetFrom=n.GetFrom,
                GetTo=n.GetTo,
                FromFilter=n.FromFilter,
                ToFilter=n.ToFilter,
                Getcost=n.Getcost,
                Onlyonedep=n.Onlyonedep,
                DepMust=n.DepMust,
                DepType=n.DepType,
                DepList=n.DepList,
                DepPricType=n.DepPricType,
                Adjustdeponprice=n.Adjustdeponprice,
                Getdepocostcent=n.Getdepocostcent,
                Getdepoacc=n.Getdepoacc,
                Getdesc=n.Getdesc,
                Salesrep=n.Salesrep,
                AdditemOutDep=n.AdditemOutDep,
                Hasextras=n.Hasextras
            });

            return res.FirstOrDefault();
        }
    }
}
