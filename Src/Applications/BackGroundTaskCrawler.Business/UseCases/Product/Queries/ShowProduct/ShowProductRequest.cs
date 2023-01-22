
using MediatR;

namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ShowProduct;

public class ShowProductRequest : IRequest<ShowProductResponse>
{
    public int ProductId { get; set; }
}