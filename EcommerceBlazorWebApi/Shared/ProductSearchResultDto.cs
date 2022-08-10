namespace EcommerceBlazorWebApi.Shared;

public class ProductSearchResultDto
{
    public IReadOnlyList<Product> Products { get; set; } = new List<Product>();
    public int Pages { get; set; }
    public int CurrentPage { get; set; }
}
