namespace EcommerceBlazorWebApi.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public IReadOnlyList<Product> Products { get; set; } = new List<Product>();

        public async Task GetProducts()
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<IReadOnlyList<Product>>>("api/product");

            if (result != null && result.Data != null)
                Products = result.Data;
        }
    }
}
