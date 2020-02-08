using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Implementations;
using WebStore.Services.Implementations;
using WebStore.Hubs;
using Data;
using Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace WebStore
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
           // services.CreateConnection(Configuration);

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSignalR();

            services.AddIdentity<User, Role>();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(60*60);
                options.Cookie.HttpOnly = true;                
                options.Cookie.IsEssential = true;
            })
                .AddAuthentication()
                .AddCookie();
            
            

            services.AddScoped<ProductManager>();
            services.AddScoped<ProductSalesManager>();
            services.AddScoped<DbContext,StoreDbContext>();
            services.AddScoped<StoreDbContext>();
            services.AddScoped<IUserStore<User>, UserStore<User>>();

            services.AddScoped<UserManager<User>>();
            //
            services.AddHttpContextAccessor();
           
            services.AddScoped<IUserValidator<User>, UserValidator<User>>();
            services.AddScoped<IPasswordValidator<User>, PasswordValidator<User>>();
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            services.AddScoped<ILookupNormalizer, UpperInvariantLookupNormalizer>();
            services.AddScoped<IRoleValidator<Role>, RoleValidator<Role>>();
            // No interface for the error describer so we can add errors without rev'ing the interface
            services.AddScoped<IdentityErrorDescriber>();
            services.AddScoped<ISecurityStampValidator, SecurityStampValidator<User>>();
            services.AddScoped<ITwoFactorSecurityStampValidator, TwoFactorSecurityStampValidator<User>>();
            services.AddScoped<IUserClaimsPrincipalFactory<User>, UserClaimsPrincipalFactory<User, Role>>();
            services.AddScoped<Microsoft.AspNetCore.Identity.RoleManager<Role>>();
            services.AddScoped<UserManager<User>>();
            services.AddScoped<SignInManager<User>>();
            //services.AddScoped<RoleManager<Role>>();
            services.AddScoped<IRoleStore<Role>,RoleStore<Role>>();
            services.AddScoped<IUserConfirmation<User>, DefaultUserConfirmation<User>>();
            services.AddScoped<ISystemClock, SystemClock>();

            //registration
            services.Configure<IdentityOptions>(options =>
            {
                // Default Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
              
            });

            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDirectoryBrowser();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseFileServer();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
       
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chatHub");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
