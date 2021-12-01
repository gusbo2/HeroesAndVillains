using Repository.Interfaces;
using Repository.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RegisterRepositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IHeroRepository, HeroRepository>();
            return services;
        }
    }
}