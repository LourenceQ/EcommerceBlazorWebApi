using EcommerceBlazorWebApi.Shared;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceBlazorWebApi.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<IReadOnlyList<Product>>>> GetProduct()
    {
        var result = await _productService.GetProductsAsync();
        return Ok(result);
    }
}
