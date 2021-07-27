using BLL.ModelsView;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IGroupf:IBaseRepo<Groupf>
    {
        Groupf GetGroupFById(decimal? id);
        object GetAllTypes(decimal Id, string type);

    }
}
