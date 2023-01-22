using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BackGroundTaskCrawler.Applications.Business;

public static class DipendencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DipendencyInjection).Assembly);

        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });

        services.AddFluentValidation(x =>
        {
            x.RegisterValidatorsFromAssemblyContaining(typeof(DipendencyInjection));
            x.AutomaticValidationEnabled = true;
        });

        object value = services.AddMediatR(typeof(DipendencyInjection).Assembly);

        return services;
    }
}
