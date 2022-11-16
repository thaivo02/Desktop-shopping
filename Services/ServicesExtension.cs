using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Services.Item;

namespace Sneakerz.Services;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient(typeof(IItemServices), typeof(ItemServices));
        return services;
    }
}