using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Project.Models;
using Project.Repositories;
using ProjectWebAPI.SharedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
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
            services.AddCors(options => options.AddPolicy("MyPolicy",
                 policybuilder => policybuilder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()
                 ));
            services.AddDbContext<ProductEntity>(options =>
            {
                options.UseSqlServer("Data Source=.;Initial Catalog=Pro_API;Integrated Security=True");
            });
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ProductEntity>();
            //services.addauthentication(options =>
            //{
            //    options.defaultauthenticatescheme = jwtbearerdefaults.authenticationscheme;
            //    options.defaultchallengescheme = jwtbearerdefaults.authenticationscheme;
            //    options.defaultscheme = jwtbearerdefaults.authenticationscheme;
            //}).addjwtbearer(options =>
            //{
            //    options.savetoken = true;
            //    options.requirehttpsmetadata = false;
            //    options.tokenvalidationparameters = new tokenvalidationparameters()
            //    {
            //        validateissuer = true,
            //        validissuer = configuration["jwt:validissuer"],
            //        validateaudience = true,
            //        validaudience = configuration["jwt:validaudience"],
            //        issuersigningkey =
            //        new symmetricsecuritykey(encoding.utf8.getbytes(configuration["jwt:secret"]))
            //    };
            //});
            services.AddControllers();
            services.AddSwaggerGen(swagger =>
            {
                //This†is†to†generate†the†Default†UI†of†Swagger†Documentation††††
                //swagger.SwaggerDoc("v1", new OpenApiInfo
                //{
                //    Version = "v1",
                //    Title = "ASP.NET†5†Web†API",
                //    Description = " ITI Projrcy"
                //});
                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "Day3.WebAPI", Version = "v1" });

                //†To†Enable†authorization†using†Swagger†(JWT)††††
                //swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                //{
                //    Name = "Authorization",
                //    Type = SecuritySchemeType.ApiKey,
                //    Scheme = "Bearer",
                //    BearerFormat = "JWT",
                //    In = ParameterLocation.Header,
                //    Description = "Enter†'Bearer'†[space]†and†then†your†valid†token†in†the†text†input†below.\r\n\r\nExample:†\"Bearer†eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
                //});
                //swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                //{
                //    {
                //    new OpenApiSecurityScheme
                //    {
                //    Reference = new OpenApiReference
                //    {
                //    Type = ReferenceType.SecurityScheme,
                //    Id = "Bearer"
                //    }
                //    },
                //    new string[] {}
                //    }
                //});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjectWebAPI v1"));
            }

            //app.UseStaticFiles();
            app.UseCors("MyPolicy");
            app.UseRouting();
            //app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
