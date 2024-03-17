

using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business;

public static class BusinessRegistiration
{
    public static IServiceCollection AddBusinessRegistiration(this IServiceCollection services)
    {
        services.AddSingleton<IBrandService, BrandManager>();
        return services;
    }
}
