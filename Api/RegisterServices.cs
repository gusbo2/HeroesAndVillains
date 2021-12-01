using Service.Interfaces;
using Service.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RegisterServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IHeroService, HeroService>();
            return services;
        }
    }
}