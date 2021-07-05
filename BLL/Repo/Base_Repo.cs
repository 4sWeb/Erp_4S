using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BLL.IRepo;
using DAL.ConnectToData;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
//using System.Data;
namespace BLL.Repo
{
    public abstract  class Base_Repo<T> : IBaseRepo<T> where T : class
    {
        protected ModelContext _Context { set; get; }
        
        private DbSet<T>  table = null;
        protected DbSet<T> DbSet
        {
            get => table  ?? (table  = _Context.Set<T>());
        }
        public Base_Repo(ModelContext context)
        {
            _Context = context;
            table = context.Set<T>();
        }
        public void Create(T Entity)
        {
            table.Add(Entity);
        }

        public void Delete(int id)
        {
            var t=table.Find(id);
            table.Remove(t);
            
        }

        public async  Task<List<T>> GetAll()
        {
            //CustomQueryBuilder<T>.GetList(table );
            return await  table.ToListAsync();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return   table.Where(expression);
        }

        public async  Task<T> GetByID(int Id)
        {
            return await  table.FindAsync(Id);
        }

        public void Update(T Entity)
        {
            table.Update(Entity);
        }
    }
}
