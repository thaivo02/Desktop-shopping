using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Repository.Account;
using Sneakerz.Repository.Cart;
using Sneakerz.Repository.CartDetail;
using Sneakerz.Repository.Item;
using Sneakerz.Repository.Receipt;
using Sneakerz.Repository.ReceiptDetail;

namespace Sneakerz.Repository;

public static class RepositoryExtension
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddTransient(typeof(IItemRepository), typeof(ItemRepository));
        services.AddTransient(typeof(IAccountRepository), typeof(AccountRepository));
        services.AddTransient(typeof(ICartRepository), typeof(CartRepository));
        services.AddTransient(typeof(IReceiptRepository), typeof(ReceiptRepository));
        services.AddTransient(typeof(ICartDetailRepository), typeof(CartDetailRepository));
        services.AddTransient(typeof(IReceiptDetailRepository), typeof(ReceiptDetailRepository));
        return services;
    }
}