namespace EcommerceBlazorWebApi.Client.Services.CategoryService;

public interface ICategoryService
{
    IReadOnlyList<Category> Categories { get; set; }
    Task GetCategories();
}
