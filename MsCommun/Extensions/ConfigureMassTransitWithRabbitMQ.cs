using MassTransit;
using MassTransit.Definition;
using MassTransit.MultiBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MsCommun.Settings;
using System.Reflection;

namespace MsCommun.Extensions
{
    public static class ConfigureMassTransitWithRabbitMQ
    {
        public static IServiceCollection AddConfigurationMassTransitWithRabbitMQ(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMassTransit(configure =>
            {
                configure.AddConsumers(Assembly.GetEntryAssembly());

                configure.UsingRabbitMq((context, configurator) =>
                {
                    var configuration = context.GetService<IConfiguration>();
                    var rabbitMQSettings = configuration.GetSection(nameof(RabbitMQSettings)).Get<RabbitMQSettings>();
                    configurator.Host(rabbitMQSettings.Host);
                    configurator.ConfigureEndpoints(context, new KebabCaseEndpointNameFormatter(rabbitMQSettings.ServiceName, false));
                });
            });

            services.AddMassTransitHostedService();

            return services;
        }
    }
}
