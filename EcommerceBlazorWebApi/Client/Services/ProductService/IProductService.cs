namespace EcommerceBlazorWebApi.Client.Services.ProductService
{
    public interface IProductService
    {
        IReadOnlyList<Product> Products { get; set; }
        Task GetProducts();
    }
}
