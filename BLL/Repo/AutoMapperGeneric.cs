using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repo
{
    public class AutoMapperGeneric<obj , ObjVM > 
    {
        public ObjVM GetOneObject(obj _object)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<obj, ObjVM>());
            var mapper = new Mapper(config);
            ObjVM _objectVM = mapper.Map<ObjVM>(_object);
            return _objectVM;
        }

        public List<ObjVM> GetlistOfObject(List<obj> _objectList)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<obj, ObjVM>());
            var mapper = new Mapper(config);
            List<ObjVM> _objectVM = mapper.Map<List<ObjVM>>(_objectList);
            return _objectVM;
        }
    }
}
