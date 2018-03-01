using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebatersMag.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace DebatersMag
{
    public class Startup
    {
       // string _testSecret = null;
       // public Startup(IHostingEnvironment env)
       // {
       //     var builder = new ConfigurationBuilder();

       //     if (env.IsDevelopment())
         //   {
           //     builder.AddUserSecrets<Startup>();
            //}

           // Configuration = builder.Build();
       // }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           

            services.AddDbContext<DebmagContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("ConStr")));
            services.AddMvc();

         //   _testSecret = Configuration["MySecret"];
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Main}/{action=Index}/{id?}");
            });
        }
    }
}
