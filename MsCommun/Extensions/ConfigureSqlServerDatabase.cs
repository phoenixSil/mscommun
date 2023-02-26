using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MsCommun.Repertoires.Contrats;
using MsCommun.Repertoires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MsCommun.Settings;

namespace MsCommun.Extensions
{
    public static class ConfigureSqlServerDatabase
    {
        public static IServiceCollection AddSqlServerDbConfiguration<T>(this IServiceCollection services, IConfiguration configuration)
            where T : DbContext
        {
            services.AddDbContext<T>(options =>
            {
                var sqlServerSetting = configuration.GetSection(nameof(SQLServerSettings)).Get<SQLServerSettings>();
                var connectionString = $"Server={sqlServerSetting.Server};Initial Catalog={sqlServerSetting.Database},{sqlServerSetting.Port};User Id={sqlServerSetting.Utilisateur};Password={sqlServerSetting.MotDePasse};";
                options.UseSqlServer(connectionString);
            });

            using var scope = services.BuildServiceProvider().CreateScope();
            var database = scope.ServiceProvider.GetRequiredService<T>();
            database.Database.Migrate();

            services.AddScoped(typeof(IRepertoireGenerique<>), typeof(RepertoireGenerique<>));

            return services;
        }
    }
}
