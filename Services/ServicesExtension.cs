using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Services.Cart;
using Sneakerz.Services.Item;
using Sneakerz.Services.Receipt;

namespace Sneakerz.Services;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services
            .AddTransient(typeof(IItemServices), typeof(ItemServices))
            .AddTransient(typeof(ICartServices), typeof(CartServices))
            .AddTransient(typeof(IReceiptServices),typeof(ReceiptServices))
            ;
        return services;
    }
}