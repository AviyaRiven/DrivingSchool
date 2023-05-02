//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
using Dal.DBContext;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection services ,IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                    .AddJsonFile($"appsettings.json", true, true);
            //var
            IConfiguration config = builder.Build();

            var connectionString = config["ConnectionString"];

            var connectionConfiguration = new CollectionConfiguration();
            //configuration.GetSection

            //string json = configuration.appsettings["ConnectionString"];
            // services.AddService<ICollectionConfiguration, CollectionConfiguration(connectionString)>();
            // services.AddSingleton<IDataContext, DataContext<Appsetting>>();

            services.AddService<ICollectionConfiguration, CollectionConfiguration>(connectionString);
            services.AddSingleton<IDataContext, DataContext<Appsetting>>();
            return services;
        }

       

    }
}
