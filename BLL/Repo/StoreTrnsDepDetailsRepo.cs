using BLL.IRepo;
using BLL.ERPModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repo
{
    public class StoreTrnsDepDetailsRepo:Base_Repo<StoreTrnsDepDetail>, IStoreTrnsDepDetails
    {
        private readonly IRepoWrapper repo;
        public StoreTrnsDepDetailsRepo(ModelContext dbContext4S):base(dbContext4S)
        {

        }
        //convert viewmodel to model and add it 
        public void convert_VMtoModel(List<StoreTransDepDetails_VM> STD_VM)
        {
            foreach (var item in STD_VM)
            {
                StoreTrnsDepDetail STDepDetail = new StoreTrnsDepDetail()
                {
                    Depdetailsid = item.Depdetailsid,
                    Ctrnsorowid = item.Ctrnsorowid,
                    Ptrnsorowid = item.Ptrnsorowid
                };
                repo._StoreTrnsDepDetails.Create(STDepDetail);


            }
        }

        //Retrive list of DepTranactionsDetails 
        public List<StoreTransDepDetails_VM> RetiveDepTransDetails(List<decimal> storeTransDepIds)
        {
            List<StoreTransDepDetails_VM> storeTransDepDetails = new List<StoreTransDepDetails_VM>();
            if (storeTransDepIds!=null)
            {

           
            foreach(var item in storeTransDepIds)
            {
                    var oneItem = GetByCondition(c => c.ProwId == item).Result.Select(s => new StoreTransDepDetails_VM
                    {
                        Item_ID = string.IsNullOrEmpty(s.Itemid.ToString()) ? 0 : (decimal)s.Itemid,
                        Unitprice = string.IsNullOrEmpty(s.Unitprice.ToString()) ? 0 : (decimal)s.Unitprice,
                        Quantity = string.IsNullOrEmpty(s.Quantity.ToString()) ? 0 : (decimal)s.Quantity,

                    }).ToList();

              
                    foreach (var DepDetailsitem in oneItem)
                    {
                        storeTransDepDetails.Add(DepDetailsitem);
                    }
                }
                
                return storeTransDepDetails;
            }

            return null;
        }
    }
}
