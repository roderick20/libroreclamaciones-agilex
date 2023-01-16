using BuzonDeSugerencias.Filter;
using BuzonDeSugerencias.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace BuzonDeSugerencias
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			string connection = Configuration.GetConnectionString("DB");
			services.AddDbContext<DBContext>(delegate (DbContextOptionsBuilder Options)
			{
				Options.UseSqlServer(connection);
			});



#if DEBUG
			services.AddControllersWithViews(delegate (MvcOptions options)
			{
				options.Filters.Add(typeof(Authentication));
			}).AddRazorRuntimeCompilation();
#else
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(typeof(Authentication));
            });
#endif
			services.AddSession(delegate (SessionOptions s)
			{
				s.IdleTimeout = TimeSpan.FromMinutes(20.0);
			});
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddTransient((Func<IServiceProvider, IPrincipal>)((IServiceProvider provider) => provider.GetService<IHttpContextAccessor>()?.HttpContext?.User));
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseStaticFiles();
			app.UseRouting();
			app.UseAuthorization();
			app.UseSession();
			app.UseEndpoints(delegate (IEndpointRouteBuilder endpoints)
			{
				endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
