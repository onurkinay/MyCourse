using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyCourse.Shared.Extensions;

public static class CommonServiceExt
{
    public static IServiceCollection AddCommonServiceExt(this IServiceCollection services,Type assembly)
    {
        services.AddHttpContextAccessor(); 
        services.AddMediatR(x => x.RegisterServicesFromAssemblyContaining(assembly));
        
        return services;
    }
}