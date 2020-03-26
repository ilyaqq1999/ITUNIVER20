﻿using AutoMapper;

using ItUniver.AspNetCore;
using ItUniver.Tasks.Application;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ItUniver.Tasks.Web
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
            services
                 .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                 .AddCookie(options =>
                   {
                       options.LoginPath = new PathString("/Account/Login");
                       options.AccessDeniedPath = new PathString("/Account/AccessDenied");
                   })
            ;

            services
                .AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                {
                    // Use the default property (Pascal) casing
                    //options.SerializerSettings.ContractResolver = new DefaultContractResolver();

                    // Configure a custom converter
                    //options.SerializerOptions.Converters.Add(new MyCustomJsonConverter());
                })
                .AddRazorRuntimeCompilation()
                ;

            services
                .AddAutoMapper(typeof(Startup).Assembly, typeof(TaskApplicationModule).Assembly);

            services
                .AddTaskCore()//Регистрация сервесов Core
                .AddTaskApplication() //Регистрация сервисов API
                .AddTaskNHibernate(Configuration.GetConnectionString("Default"))
                ;

            services
                .AddCore();
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

            app.UseAuthentication();    // аутентификация
            app.UseAuthorization();     // авторизация

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}