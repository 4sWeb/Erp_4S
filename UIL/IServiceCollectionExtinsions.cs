using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using BLL.Repo;
using BLL.IRepo;
namespace Erp_4S
{
   
        public static class IServiceCollectionExtensions
        {
            public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
            {
                // Configure DbContext with Scoped lifetime   
                services.AddDbContext<DbContext4S>(options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("ManagementConnection"));
                    //options.UseLazyLoadingProxies();
                }
                );

                services.AddScoped<Func<DbContext4S >>((provider) => () => provider.GetService<DbContext4S >());
                services.AddScoped<DbFactory>();

                return services;
            }

            public static IServiceCollection AddRepositories(this IServiceCollection services)
            {
            return services
                .AddScoped(typeof(IBaseRepo<>), typeof(Base_Repo<>))
                //.AddScoped<IProjectsRepo, ProjectsRepo>()
                //.AddScoped<IMembersRepo, MembersRepo>()
                ;
                    
            }

           
        }

    
}
