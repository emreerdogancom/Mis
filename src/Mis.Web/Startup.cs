using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mis.Business.Abstract;
using Mis.Business.Concrete;
using Mis.Core.Repositories.Entity;
using Mis.Core.UnitOfWorks;
using Mis.DataAccess.Concrete.EF.Contexts;
using Mis.DataAccess.Concrete.EF.Repositories;
using Mis.DataAccess.Concrete.UnitOfWorks;

namespace Mis.Web
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
            
            services.AddControllersWithViews();
            services.AddOptions();
            services.AddMemoryCache();


            /* Master Data */
            services.AddScoped<IFromFactorRepository, FromFactorRepository>();
            services.AddScoped<IProcessorRepository, ProcessorRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();


            /* Categories */
            services.AddScoped<IDesktopRepository, DesktopRepository>();
            services.AddScoped<IServerRepository, ServerRepository>();
            services.AddScoped<ILaptopRepository, LaptopRepository>();
            services.AddScoped<ITabletRepository, TabletRepository>();


            /* Services */
            services.AddScoped<IDesktopService, DesktopService>();
            services.AddScoped<IServerService, ServerService>();
            services.AddScoped<ILaptopService, LaptopService>();
            services.AddScoped<ITabletService, TabletService>();

            /* Unit Of Works */
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            /* Database */
            services.AddDbContext<MisDbContext>();
            //services.AddDbContext<MisDbContext>(options => options.UseInMemoryDatabase("memory"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
