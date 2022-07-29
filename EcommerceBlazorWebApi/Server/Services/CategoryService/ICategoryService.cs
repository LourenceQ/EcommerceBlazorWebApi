namespace EcommerceBlazorWebApi.Server.Services.CategoryService;

public interface ICategoryService
{
    Task<ServiceResponse<IReadOnlyList<Category>>> GetCategories();
}
