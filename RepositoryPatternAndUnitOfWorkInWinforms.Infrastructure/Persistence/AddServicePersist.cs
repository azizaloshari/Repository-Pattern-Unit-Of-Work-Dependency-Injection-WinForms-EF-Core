using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternAndUnitOfWorkInWinforms.EFCore;


namespace RepositoryPatternAndUnitOfWorkInWinforms.Infrastructure.Persistence
{
    public static class AddServicePersist
    {
        public static IServiceCollection GetServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(ServiceLifetime.Singleton, ServiceLifetime.Scoped);
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
