using EcommerceBlazorWebApi.Shared;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceBlazorWebApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;
        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<IReadOnlyList<Product>>>> GetProduct()
        {
            var products = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>()
            {
                Data = products 
            };

            return Ok(response);
        }
    }
}
