using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Repository.Account;
using Sneakerz.Repository.Cart;
using Sneakerz.Repository.CartDetail;
using Sneakerz.Repository.Item;
using Sneakerz.Repository.Receipt;

namespace Sneakerz.Repository;

public static class RepositoryExtension
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(IItemRepository), typeof(ItemRepository));
        services.AddScoped(typeof(IAccountRepository), typeof(AccountRepository));
        services.AddScoped(typeof(ICartRepository), typeof(CartRepository));
        services.AddScoped(typeof(IReceiptRepository), typeof(ReceiptRepository));
        services.AddScoped(typeof(ICartDetailRepository), typeof(CartDetailRepository));
        return services;
    }
}