
using AutoMapper;
using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using MediatR;

namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ShowProduct;

public class ShowProductHandler : IRequestHandler<ShowProductRequest, ShowProductResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseReadRepository<Domains.Entities.Models.Product> _productRepository;

    public ShowProductHandler(IMapper mapper, IUnitOfWork uow)
    {
        _mapper = mapper;
        _productRepository = uow.GetReadRepository<Domains.Entities.Models.Product>();
    }

    public async Task<ShowProductResponse> Handle(ShowProductRequest request, CancellationToken cancellationToken)
    {
        var response = await _productRepository.Get(x=>x.ProductId == request.ProductId);

        return _mapper.Map<ShowProductResponse>(response);
    }
}