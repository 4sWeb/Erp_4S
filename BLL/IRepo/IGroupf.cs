using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepo
{
    public interface IGroupf:IBaseRepo<Groupf>
    {
        Groupf GetGroupFById(decimal? id);
        object GetAllTypes(decimal Id, string type);
        //alzahraa 4/8/2021 trying to retrive list of To Type
        Task<List<object>> GetAllToTypes(decimal id);
    }
}
