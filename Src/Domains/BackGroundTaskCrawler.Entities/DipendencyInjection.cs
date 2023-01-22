
using BackGroundTaskCrawler.Domains.Entities.Contracts;
using BackGroundTaskCrawler.Domains.Entities.Policies;
using Microsoft.Extensions.DependencyInjection;

namespace BackGroundTaskCrawler.Domains.Entities
{
    public static class DipendencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IProductPolicies, ProductPolicies>();

            return services;
        }
    }
}
