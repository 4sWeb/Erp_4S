﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
namespace BLL.IRepo
{
    public interface IBaseRepo<T>
    {
        List<T>GetAll();
        T GetByID(int Id);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
        void  Create(T Entity);
        void  Update(T Entity);
        void  Delete(int id);
    }
}
