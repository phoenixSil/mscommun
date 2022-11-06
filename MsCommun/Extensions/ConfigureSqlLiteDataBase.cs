using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MsCommun.Repertoires.Contrats;
using MsCommun.Repertoires;
using MsCommun.Settings;

namespace MsCommun.Extensions
{
    public static class ConfigureSqlLiteDataBase
    {
        public static IServiceCollection AddSqlListeDbConfiguration<T>(this IServiceCollection services, string connectionstring)
            where T: DbContext
        {
            services.AddDbContext<T>(options =>
            {
                options.UseSqlite(connectionstring);
            });

            services.AddScoped(typeof(IRepertoireGenerique<>), typeof(RepertoireGenerique<>));

            return services;
        }
    }
}
