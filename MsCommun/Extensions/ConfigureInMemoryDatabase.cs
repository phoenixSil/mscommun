using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MsCommun.Repertoires.Contrats;
using MsCommun.Repertoires;

namespace MsCommun.Extensions
{
    public static class ConfigureInMemoryDatabase
    {
        public static IServiceCollection AddInMemoryDataBaseConfiguration<T>(this IServiceCollection services, string connectionstring)
           where T : DbContext
        {
            services.AddDbContext<T>(options =>
            {
                options.UseInMemoryDatabase(connectionstring);
            });

            services.AddScoped(typeof(IRepertoireGenerique<>), typeof(RepertoireGenerique<>));

            return services;
        }
    }
}
