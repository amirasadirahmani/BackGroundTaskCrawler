
using AutoMapper;
using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using MediatR;

namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ProductList;

public class ProductListHandler : IRequestHandler<ProductListRequest, ProductListResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseReadRepository<Domains.Entities.Models.Product> _productRepository;

    public ProductListHandler(IMapper mapper, IUnitOfWork uow)
    {
        _mapper = mapper;
        _productRepository = uow.GetReadRepository<Domains.Entities.Models.Product>();
    }

    public async Task<ProductListResponse> Handle(ProductListRequest request, CancellationToken cancellationToken)
    {
        var response = await _productRepository.PagingListAsc(
        x=>true,
        false,
        x => x.ProductId,
        request.PageSize, request.Page);

        return new ProductListResponse(_mapper.Map<IList<ProductList>>(response));
    }
}
