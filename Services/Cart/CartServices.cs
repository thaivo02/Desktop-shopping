
using Sneakerz.Model;
using Sneakerz.Repository.Cart;
using Sneakerz.Repository.CartDetail;

namespace Sneakerz.Services.Cart;

public class CartServices : ICartServices
{
    private readonly ICartRepository _cartRepository;
    private readonly ICartDetailRepository _cartDetailRepository;

    public CartServices(
        ICartRepository cartRepository, 
        ICartDetailRepository cartDetailRepository
        )
    {
        _cartRepository = cartRepository;
        _cartDetailRepository = cartDetailRepository;
    }

    public CartDto GetCart(int userId)
    {
        var cart =  _cartRepository.GetCart(userId);;
        var cartDetail = _cartDetailRepository.GetCartDetail(cart.Id);
        var cartDto = new CartDto()
        {
            Cart = cart,
            CartDetails = cartDetail
        };
        return cartDto;
    }

    public int GetCartMaxId()
    {
        var cart = _cartRepository.GetAll().ToList();
        if (cart.Count == 0)
            return 0;
        return cart.Max(c => c.Id);
    }
}