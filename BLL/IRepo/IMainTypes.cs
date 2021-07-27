using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.IRepo
{
    public interface IMainTypes:IBaseRepo<MainType>
    {
        MainType GetMainTypeById(decimal? id);

        string GetNameFromMAinType(decimal? id);
    }
}
