namespace EcommerceBlazorWebApi.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int productId)
    {
        var response = new ServiceResponse<Product>();
        var product = await _context.Products.FindAsync(productId);
        if(product == null)
        {
            response.Success = false;
            response.Message = "Product does not exist.";
        }
        else
        {
            response.Data = product;
        }

        return response;
    }

    public async Task<ServiceResponse<IReadOnlyList<Product>>> GetProductsAsync()
    {
        var response = new ServiceResponse<IReadOnlyList<Product>>()
        {
            Data = await _context.Products.ToListAsync()
        };

        return response;
    }

    public async Task<ServiceResponse<IReadOnlyList<Product>>> GetProductsByCategory(
        string categoryUrl)
    {
        var response = new ServiceResponse<IReadOnlyList<Product>>
        {
            Data = await _context.Products.Where(p => 
                p.Category!.Url.ToLower().Equals(categoryUrl.ToLower()))
                .ToListAsync()  
        };

        return response;
    }
}
