namespace EcommerceBlazorWebApi.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<IReadOnlyList<Product>>> GetProductsAsync();
    Task<ServiceResponse<Product>> GetProductByIdAsync(int productId);
    Task<ServiceResponse<IReadOnlyList<Product>>> GetProductsByCategory(string categoryUrl);
    Task<ServiceResponse<IReadOnlyList<Product>>> SearchProducts(string searchText);
    Task<ServiceResponse<IReadOnlyList<string>>> GetProductSearchSuggestions(string searchText);
    Task<ServiceResponse<IReadOnlyList<Product>>> GetFeaturedProducts();
}
