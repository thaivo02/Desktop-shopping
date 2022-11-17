using Microsoft.EntityFrameworkCore;
using Sneakerz.Model;

namespace Sneakerz.Repository.Item;

public class ItemRepository : Repository<Entity.Item, string>, IItemRepository
{
    public ItemRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public void AddItem(Entity.Item item)
    {
        Add(item);
        SaveChanges();
    }
    
    public List<Entity.Item> GetAllItems(ItemQuery queryData)
    {
        var items = GetAll();
        if (queryData.Id is not null)
        {
            items = items.Where(i => EF.Functions.Like(i.Id, $"%{queryData.Id}"));
        }

        if (queryData.Name is not null)
        {
            items = items.Where(i => EF.Functions.Like(i.Name, $"${queryData.Name}$"));
        }

        if (queryData.Category is not null)
        {
            items = items.Where(i => i.CaregoryId == queryData.Category);
        }
        
        return items.ToList();
    }

    public Entity.Item GetItemDetail(string id)
    {
        var item = GetAll().FirstOrDefault(i => i.Id == id);
        return item;
    }
}