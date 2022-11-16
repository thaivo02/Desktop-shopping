using Sneakerz.Model;

namespace Sneakerz.Services.Item;

public interface IItemServices
{
    public List<Entity.Item> GetListItem(ItemQuery queryData);

    public Entity.Item GetItemDetail(string id);
}