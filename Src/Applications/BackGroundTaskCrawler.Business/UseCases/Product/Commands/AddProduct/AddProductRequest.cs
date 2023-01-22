
using MediatR;

namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Commands.AddProduct;

public class AddProductRequest : IRequest<AddProductResponse>
{
    public string ProductName { get; set; }
    public string ImageLink { get; set; }
    public decimal Price { get; set; }
    public string Dimention { get; set; }
    public float Weight { get; set; }
}
