using AutoMapper;
using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MappingAdapter
{
   public class StoreTransMasterMapper: StoreTrnsM
    {
        public StoreTransMasterMapper()
        {
            var config = new MapperConfiguration(cfg =>
                   cfg.CreateMap<StoreTrnsM, StoreTransMaster_VM>());
             //Using automapper
            var mapper = new Mapper(config);
           // CreateMap<StoreTransMaster_VM, StoreTrnsM();
        }
    }
}
