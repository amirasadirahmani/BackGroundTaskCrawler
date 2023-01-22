
using AutoMapper;
using BackGroundTaskCrawler.Applications.Business.UseCases.Product.Commands.AddProduct;
using BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ProductList;
using BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ShowProduct;
using BackGroundTaskCrawler.Domains.Entities.Models;

namespace BackGroundTaskCrawler.Applications.Business.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, AddProductRequest>().ReverseMap();

        CreateMap<Product, ProductList>();

        CreateMap<Product, ShowProductResponse>();
    }
}
