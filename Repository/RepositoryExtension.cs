using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Repository.Account;
using Sneakerz.Repository.Cart;
using Sneakerz.Repository.Item;
using Sneakerz.Repository.Receipt;

namespace Sneakerz.Repository;

public static class RepositoryExtension
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddSingleton<IItemRepository, ItemRepository>();
        services.AddSingleton<IAccountRepository, AccountRepository>();
        services.AddSingleton<ICartRepository, CartRepository>();
        services.AddSingleton<IReceiptRepository, ReceiptRepository>();
        return services;
    }
}