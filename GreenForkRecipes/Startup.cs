using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GreenForkRecipes.Filters;
using GreenForkRecipes.Repositories;
using GreenForkRecipes.Services;
using GreenForkRecipes.Services.AutoMapper;
using GreenForkRecipes.Services.Helpers;
using GreenForkRecipes.Services.ModelServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GreenForkRecipes
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
            services.AddAutoMapper(m => m.AddProfile(new AutoMapperConfiguration()));
            services.AddSingleton(Configuration.GetSection("AppSettings").Get<AppSettings>());
            services.AddDbContext<RecipesDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default Connection")));
            
            services.AddScoped<UserRepository>();
            services.AddScoped<RecipeRepository>();
            services.AddScoped<RecipeCommentRepository>();

            services.AddScoped<UserService>();
            services.AddScoped<RecipeService>();
            services.AddScoped<RecipeCommentService>();


            services.AddScoped<AuthenticationFilter>();

            services.AddScoped<FileHelperService>();
            services.AddScoped<ImageUploadService>();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddControllersWithViews();
            
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,RecipesDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            context.Database.Migrate();

            app.UseSession();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Recipe}/{action=Index}/{id?}");
            });
        }
    }
}
