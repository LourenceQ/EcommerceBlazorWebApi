namespace EcommerceBlazorWebApi.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        IReadOnlyList<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductById(int productId);
    }
}
