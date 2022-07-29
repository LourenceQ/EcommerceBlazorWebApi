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

    [HttpGet("{productId}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProductById(int productId)
    {
        var result = await _productService.GetProductByIdAsync(productId);
        return Ok(result);
    }

    [HttpGet("category/{categoryUrl}")]
    public async Task<ActionResult<ServiceResponse<IReadOnlyList<Product>>>> GetProductsByCategory(string categoryUrl)
    {
        var result = await _productService.GetProductsByCategory(categoryUrl);

        return Ok(result);
    }
    
}
