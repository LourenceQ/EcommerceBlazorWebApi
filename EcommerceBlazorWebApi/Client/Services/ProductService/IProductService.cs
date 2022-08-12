namespace EcommerceBlazorWebApi.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        IReadOnlyList<Product> Products { get; set; }
        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProductById(int productId);
        Task SearchProducts(string searchText, int page);
        Task<IReadOnlyList<string>> GetProductSearchSuggestions(string searchText); 
    }
}
