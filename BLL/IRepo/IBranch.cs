using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepo
{
    public interface IBranch :IBaseRepo<Branch1>
    {
        Task<List<object>> GetAllBranches(decimal Id);

    }
}
