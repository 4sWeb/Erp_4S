﻿using System;
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
        private bool disposedValue;

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
            if (t != null)
            {
                table.Remove(t);
            }
        }

        public async  Task<List<T>> GetAll()
        {
            //CustomQueryBuilder<T>.GetList(table );
            
            return await  table.ToListAsync();
        }

        public async Task<List<T>> GetByCondition(Expression<Func<T, bool>> expression)
        {
            var result = await table.Where(expression).ToListAsync();
            
            return result;
        }
        public virtual IEnumerable<T> Get( Expression<Func<T, bool>> filter = null,Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        public async  Task<T> GetByID(decimal Id)
        {
            return await  table.FindAsync(Id);
        }

        public void Update(T Entity)
        {
            table.Update(Entity);
        }

        
    }
}
