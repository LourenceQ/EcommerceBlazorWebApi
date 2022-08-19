namespace EcommerceBlazorWebApi.Client.Services.CartService;

public interface ICartService
{
    event Action OnChange;
    Task AddToCart(CartItem cartItem);
    Task<IReadOnlyList<CartItem>> GetCartItems();
    Task<IReadOnlyList<CartProductResponseDto>> GetCartProducts();
}
