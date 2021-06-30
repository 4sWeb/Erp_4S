using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BLL.Repo;
namespace BLL.Repo
{
    public class DbFactory:IDisposable 
    {
        
            private bool _disposed;
            private Func<DbContext4S> _instanceFunc;
            private DbContext4S  _dbContext;
            public DbContext DbContext => _dbContext ?? (_dbContext = _instanceFunc.Invoke());

            public DbFactory(Func<DbContext4S> dbContextFactory)
            {
                _instanceFunc = dbContextFactory;
            }

            public void Dispose()
            {
                if (!_disposed && _dbContext != null)
                {
                    _disposed = true;
                    _dbContext.Dispose();
                }
            }
        }
    }

