using Sneakerz.Model;
using Sneakerz.Repository;
using Sneakerz.Repository.Cart;
using Sneakerz.Repository.Item;

namespace Sneakerz.Services.Item;

public interface IItemServices
{
    public List<Entity.Item> GetListItem(ItemQuery queryData);
}