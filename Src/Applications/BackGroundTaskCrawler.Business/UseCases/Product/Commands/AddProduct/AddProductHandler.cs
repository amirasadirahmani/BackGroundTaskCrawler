
using AutoMapper;
using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using MediatR;
namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Commands.AddProduct;

internal class AddProductHandler : IRequestHandler<AddProductRequest, AddProductResponse>
{
    private readonly IUnitOfWork _uow;
    private readonly IBaseWriteRepository<Domains.Entities.Models.Product> _productRepository;
    private readonly IBaseReadRepository<Domains.Entities.Models.Product> _productReadRepository;
    private readonly IMapper _mapper;

    public AddProductHandler(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _productRepository = _uow.GetWriteRepository<Domains.Entities.Models.Product>();
        _mapper = mapper;
    }

    public async Task<AddProductResponse> Handle(AddProductRequest request, CancellationToken cancellationToken)
    {
        var existedProduct = await _productReadRepository.Get(x => x.ProductName == request.ProductName
                                 && x.Price == request.Price
                                 && x.Dimention == request.Dimention);
        if (existedProduct==null)
        {
            var model = _mapper.Map<Domains.Entities.Models.Product>(request);

            await _productRepository.Create(model);
            await _uow.SaveAsync();
        }


        return new AddProductResponse();
    }
}
