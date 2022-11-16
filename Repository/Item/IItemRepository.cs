using Sneakerz.Model;

namespace Sneakerz.Repository.Item;

public interface IItemRepository : IRepository<Entity.Item, string>
{
    public List<Entity.Item> GetAllItems(ItemQuery queryData);
}