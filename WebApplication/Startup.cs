using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication.Domain;
using WebApplication.Domain.Repositories.Abstract;
using WebApplication.Domain.Repositories.EntityFramework;
using WebApplication.Service;

namespace WebApplication
{
    public class Startup
    {
        
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config());
            
            // Какиета сервиси хуй пойми чо и нахіба
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();
            
            // Падключаим БД
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "Hell";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin");});
            });
            
            services.AddControllersWithViews(x =>
                {
                    x.Conventions.Add(new AdminAreaAuthorization("Admin","AdminArea"));
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
            
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            // Есля чтата паламалася то тута нам скажут по это
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } 
            
            // А вот ета штучка падключаит всякие css js ect
            app.UseStaticFiles();
             
            app.UseRouting();
            
            // Тута праходит смотр морды нашега уважаимава пользавателя
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
            
            // Какиета енпоинты хуеинты марштуры кароче
            app.UseEndpoints(endpoints =>
            {
                // Так а эта маршрутик па дифолту
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                
                endpoints.MapControllerRoute("admin","{area:exists}/{controller=Home}/{action=Index}/{id?}");
                
            });
        }
    }
} 