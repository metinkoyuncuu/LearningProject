

using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;


namespace Business;

public static class BusinessRegistiration
{
    public static IServiceCollection AddBusinessRegistiration(this IServiceCollection services)
    {
        services.AddSingleton<IBrandService, BrandManager>();
        return services;
    }
}
