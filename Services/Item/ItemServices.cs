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

    public List<Entity.Item> GetListItem(ItemQuery queryData)
    {
        var items = _itemRepository.GetAllItems(queryData);
        return items;
    }
}