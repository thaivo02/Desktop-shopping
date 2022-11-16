using Sneakerz.Model;

namespace Sneakerz.Services.Cart;

public interface ICartServices
{
    public CartDto GetCart(int userId);

}