using EcommerceBlazorWebApi.Server.Services.CartService;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceBlazorWebApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly Services.CartService.ICartService _cartService;

        public CartController(Services.CartService.ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponseDto>>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = await _cartService.GetCartProducts(cartItems);
            return Ok(result);
        }
    }
}
