using Sneakerz.Model;

namespace Sneakerz.Repository.Item;

public interface IItemRepository : IRepository<Entity.Item, string>
{
    public void AddItem(Entity.Item item);
    public List<Entity.Item> GetAllItems(ItemQuery queryData);
    public Entity.Item GetItemDetail(string id);
}