
using AutoMapper;
using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using MediatR;

namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ShowProduct;

//public class ShowProductHandler : IRequestHandler<ShowProductRequest, ShowProductResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly IBaseReadRepository<Domains.Entities.Models.Product> _ProductRepository;

//    public ShowProductHandler(IMapper mapper, IUnitOfWork uow)
//    {
//        _mapper = mapper;
//        _ProductRepository = uow.GetReadRepository<Domains.Entities.Models.Product>();
//    }

//    public async Task<ShowProductResponse> Handle(ShowProductRequest request, CancellationToken cancellationToken)
//    {
//        var response = await _ProductRepository.Get();

//        return _mapper.Map<ShowProductResponse>(response);
//    }
//}