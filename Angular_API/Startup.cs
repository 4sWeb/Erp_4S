using BLL.IRepo;
using BLL.Repo;
using DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_API
{
    public class Startup
    {
        //private string MyAllowSpecificOrigins = "AllowOrigia";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews(); 
            services.AddControllers();
            services.AddDbContext<ModelContext>(options =>
            options.UseOracle(Configuration.GetConnectionString("TestConn")));

            services.AddScoped<IRepoWrapper,RepoWrapper>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Angular_API", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });

            //added by alzahraa (try to solve CORS problem) 26-7-2021
            //services.AddCors(options =>
            //{
            //    options.AddPolicy(
            //      "CorsPolicy",
            //      builder => builder.WithOrigins("http://localhost:4200")
            //      .AllowAnyMethod()
            //      .AllowAnyHeader()
            //      .AllowCredentials());
            //});

            services.AddCors(options =>
            {
                options.AddPolicy(name:"MyAllowSpecificOrigins",
                builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });

            });
            //

            //services.AddCors(c => c.AddPolicy("AllowOrigia", option => option.AllowAnyOrigin())) ;
            //services.AddCors(c => c.AddPolicy("CorePolicy", builder => builder.AllowAnyMethod()));
            //services.AddCors(c => c.AddPolicy("CorePolicy", builder => builder.AllowAnyHeader()));



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Angular_API v1");
                    //c.RoutePrefix = string.Empty;      //UnComment in production
                });

                //added by alzahraa (try to solve CORS problem) 26-7-2021
                // app.UseCors(MyAllowSpecificOrigins);
                
               // app.UsePreflightRequestHandler();

            }
           

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("MyAllowSpecificOrigins");
            //app.UseCors(option => option.AllowAnyOrigin());
            //app.UseCors(option => option.AllowAnyMethod());
            //app.UseCors(option => option.AllowAnyHeader());
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
