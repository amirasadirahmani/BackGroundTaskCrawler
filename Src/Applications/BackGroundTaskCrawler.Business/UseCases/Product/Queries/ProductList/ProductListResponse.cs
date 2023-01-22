
namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ProductList;

public class ProductListResponse
{
    public ProductListResponse(IList<ProductList> list)
    {
        List = list;
    }

    public IList<ProductList> List { get; set; }
}

public class ProductList
{
    public string ProductName { get; set; }
    public string ImageLink { get; set; }
    public decimal Price { get; set; }
    public string Dimention { get; set; }
    public float Weight { get; set; }
}
