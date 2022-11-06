using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MsCommun.Repertoires.Contrats;
using MsCommun.Repertoires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsCommun.Extensions
{
    public static class ConfigureSqlServerDatabase
    {
        public static IServiceCollection AddSqlServerDbConfiguration<T>(this IServiceCollection services, string connectionstring)
            where T : DbContext
        {
            services.AddDbContext<T>(options =>
            {
                options.UseSqlServer(connectionstring);
            });

            services.AddScoped(typeof(IRepertoireGenerique<>), typeof(RepertoireGenerique<>));

            return services;
        }
    }
}
