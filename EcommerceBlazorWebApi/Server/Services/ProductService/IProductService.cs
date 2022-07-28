namespace EcommerceBlazorWebApi.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<IReadOnlyList<Product>>> GetProductsAsync();
}
