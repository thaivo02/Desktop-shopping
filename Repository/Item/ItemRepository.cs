namespace Sneakerz.Repository.Item;

public class ItemRepository : Repository<Entity.Item, int>, IItemRepository
{
    public ItemRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public List<Entity.Item> GetAllItem()
    {
        var items = GetAll().ToList();
        return items;
    }
}