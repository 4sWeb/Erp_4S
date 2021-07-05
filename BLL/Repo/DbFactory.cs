using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BLL.Repo;
namespace BLL.Repo
{
    public class DbFactory:IDisposable 
    {
        
            private bool _disposed;
            private Func<ModelContext> _instanceFunc;
            private ModelContext _dbContext;
            public DbContext DbContext => _dbContext ?? (_dbContext = _instanceFunc.Invoke());

            public DbFactory(Func<ModelContext> dbContextFactory)
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

