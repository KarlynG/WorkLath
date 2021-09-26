using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLath.Bl.Config;
using Microsoft.OpenApi.Models;
using WorkLath.Config;
using WorkLath.Model.IoC;
using WorkLath.Services.IoC;
using WorkLath.Core.Settings;

namespace WorkLath
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
            services.AddControllers();
            services.ConfigSqlServerDbContext(Configuration.GetConnectionString("DefaultConnection"));
            services.AddControllers(options => options.EnableEndpointRouting = false)
                .AddNewtonsoftJson()
                .ConfigFluentValidation();

            services.ConfigAutoMapper();
            services.ConfigOData();
            services.ConfigSwagger();
            services.Configure<JwtSettings>(Configuration.GetSection("JwtSettings"));
            services.ConfigJwtAuth(Configuration);

            services.AddModelRegistry();
            services.AddServiceRegistry();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAppSwagger();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMvc(routeBuilder => routeBuilder.UseAppOData());
        }
    }
}
