using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NETCoreWebAPI_Blog_DAL.Abstract;
using NETCoreWebAPI_Blog_DAL.Concreate;
using NETCoreWebAPI_Blog_DB.Context;
using Swashbuckle.AspNetCore.Swagger;

namespace NETCOREWebAPI_Blog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("CoreSwagger", new Info
                {
                    Title = "Swagger on ASP.NET Core",
                    Version = "1.0.0",
                    Description = " Swagger on (ASP.NET Core 2.1)",
                    Contact = new Contact()
                    {
                        Name = "Swagger Implementation Furkan Süğlün",
                        Url = "http://github.com/furkansuglun",
                        Email = "suglunfurkan@gmail.com"
                    },
                    TermsOfService = "http://swagger.io/terms/"
                });
            });

            //services.AddDbContext<BlogContext>();
            services.AddDbContext<BlogContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddSingleton <, > ();
            //services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseStaticFiles();
            app.UseSwagger()
            .UseSwaggerUI(c =>
            {
                //TODO: Either use the SwaggerGen generated Swagger contract (generated from C# classes)
                c.SwaggerEndpoint("/swagger/CoreSwagger/swagger.json", "Swagger for .Net Core");

                //TODO: Or alternatively use the original Swagger contract that's included in the static files
                // c.SwaggerEndpoint("/swagger-original.json", "Swagger Petstore Original");
            });


            app.UseHttpsRedirection();
            app.UseMvc(x =>
            {
                x.MapRoute(name: "default",
  template: "{controller}/{action}/{id?}",
  defaults: new { controller = "Home", action = "Index" });
            });
        }

    }
}
