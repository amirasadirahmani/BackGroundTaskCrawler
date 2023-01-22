
using AutoMapper;
using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using MediatR;

namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ProductList;

//public class ProductListHandler : IRequestHandler<ProductListRequest, ProductListResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly IBaseReadRepository<Domains.Entities.Models.Product> _ProductRepository;

//    public ProductListHandler(IMapper mapper, IUnitOfWork uow)
//    {
//        _mapper = mapper;
//        _ProductRepository = uow.GetReadRepository<Domains.Entities.Models.Product>();
//    }

//    public async Task<ProductListResponse> Handle(ProductListRequest request, CancellationToken cancellationToken)
//    {

//        var response = await _ProductRepository.PagingListAsc(
        
//        false,
//        x => x.,
//        request.PageSize, request.Page);

//        return new ProductListResponse(_mapper.Map<IList<ProductList>>(response));
//    }
//}
