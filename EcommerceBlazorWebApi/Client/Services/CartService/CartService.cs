using Blazored.LocalStorage;

namespace EcommerceBlazorWebApi.Client.Services.CartService;

public class CartService : ICartService
{
    private readonly ILocalStorageService _localStorage;
    private readonly HttpClient _http;

    public CartService(ILocalStorageService localStorage, HttpClient http)
    {
        _localStorage = localStorage;
        _http = http;
    }

    public event Action? OnChange;

    public async Task AddToCart(CartItem cartItem)
    {
        var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
        if(cart == null)
        {
            cart = new List<CartItem>();
        }
        cart.Add(cartItem);

        await _localStorage.SetItemAsync("cart", cart);
        OnChange?.Invoke();
    }

    public async Task<IReadOnlyList<CartItem>> GetCartItems()
    {
        var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
        if (cart == null)
        {
            cart = new List<CartItem>();
        }
        return cart;
    }

    public async Task<IReadOnlyList<CartProductResponseDto>> GetCartProducts()
    {
        var cartItems = await _localStorage.GetItemAsync<IReadOnlyList<CartItem>>("cart");

        var response = await _http.PostAsJsonAsync("api/cart;products", cartItems);

        var cartProducts = await response
            .Content.ReadFromJsonAsync<ServiceResponse<IReadOnlyList<CartProductResponseDto>>>();

        return cartProducts.Data;

    }
}
