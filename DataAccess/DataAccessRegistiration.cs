

using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public static class DataAccessRegistiration
{
    public static IServiceCollection AddDataAccessRegistiration(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<LearningContext>(
                        options => options
                        .UseSqlServer(configuration
                        .GetConnectionString
                        ("LearningConnectionString")
                    ));
        services.AddSingleton<IBrandDal, EfBrandDal>();
        return services;
    }
}
