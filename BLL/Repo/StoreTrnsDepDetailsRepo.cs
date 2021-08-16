using BLL.IRepo;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
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
    }
}
