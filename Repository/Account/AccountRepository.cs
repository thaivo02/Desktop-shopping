namespace Sneakerz.Repository.Account;

public class AccountRepository : Repository<Entity.Account, int>,IAccountRepository
{
    public AccountRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}