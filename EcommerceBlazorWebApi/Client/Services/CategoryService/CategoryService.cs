namespace EcommerceBlazorWebApi.Client.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _http;

    public CategoryService(HttpClient http)
    {
        _http = http;
    }

    public IReadOnlyList<Category> Categories { get; set; } = new List<Category>();  

    public async Task GetCategories()
    {
        var response = await _http
            .GetFromJsonAsync<ServiceResponse<IReadOnlyList<Category>>>("api/category");

        if(response != null && response.Data!= null)
            Categories = response.Data;
    }
}
