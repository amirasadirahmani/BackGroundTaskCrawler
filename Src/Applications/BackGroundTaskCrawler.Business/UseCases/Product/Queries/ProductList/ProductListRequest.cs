
using MediatR;

namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ProductList;

public class ProductListRequest : IRequest<ProductListResponse>
{    

    public int PageSize { get; set; }

    public int Page { get; set; }
}
