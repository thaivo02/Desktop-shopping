using Sneakerz.Model;

namespace Sneakerz.Services.Item;

public interface IItemServices
{
    public void AddItem(Entity.Item item);

    public List<Entity.Item> GetListItem(ItemQuery queryData);

    public Entity.Item GetItemDetail(string id);
}