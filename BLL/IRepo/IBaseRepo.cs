using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
namespace BLL.IRepo
{
    public interface IBaseRepo<T>
    {
        Task<List<T>>GetAll();
        Task<T> GetByID(int Id);
        Task<List<T>> GetByCondition(Expression<Func<T, bool>> expression);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> order = null, string includeproperties = "");
        void  Create(T Entity);
        void  Update(T Entity);
        void  Delete(int id);
    }
}
