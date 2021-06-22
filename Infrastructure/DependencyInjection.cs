using Microsoft.Extensions.DependencyInjection;

namespace url_shortener_api.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton();

            services.AddTransient<IRepository, Repository>();
        }
    }
}