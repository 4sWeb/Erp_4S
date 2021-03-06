using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepo
{
    public interface IUserstrans : IBaseRepo<Userstran>
    {
        Task<List<Userstran>> GetByUserID(int id);
    }
}
