using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using BackGroundTaskCrawler.Infrastructures.Persistanse.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackGroundTaskCrawler.Infrastructures.Persistanse;

public static class DipendencyInjection
{
    public static IServiceCollection AddPresistance(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<Contexts.CrawlerContext>(cfg => cfg.UseSqlServer(config.GetConnectionString("Default")));

        services.AddScoped(typeof(IBaseReadRepository<>), typeof(BaseReadRepository<>));
        services.AddScoped(typeof(IBaseWriteRepository<>), typeof(BaseWriteRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}