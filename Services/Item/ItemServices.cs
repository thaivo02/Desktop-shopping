using Sneakerz.Model;
using Sneakerz.Repository.Item;

namespace Sneakerz.Services.Item;

public class ItemServices : IItemServices
{
    private readonly IItemRepository _itemRepository;

    public ItemServices(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
    
    // Ví dụ t muốn thêm item
    // Từ service mới gọi repo
    public void AddItem(Entity.Item item)
    {
        _itemRepository.AddItem(item);
    }

    public List<Entity.Item> GetListItem(ItemQuery queryData)
    {
        var items = _itemRepository.GetAllItems(queryData);
        return items;
    }

    public Entity.Item GetItemDetail(string id)
    {
        return _itemRepository.GetItemDetail(id);
    }
}