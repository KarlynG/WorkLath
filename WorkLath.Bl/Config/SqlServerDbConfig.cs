using WorkLath.Model.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Model.Context;

namespace WorkLath.Bl.Config
{
    public static class SqlServerDbConfig
    {
        public static IServiceCollection ConfigSqlServerDbContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<WorkLathContext>(options => options.UseSqlServer(connection));

            return services;
        }
    }
}
