
using AutoMapper;
using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using MediatR;
namespace BackGroundTaskCrawler.Applications.Business.UseCases.Product.Commands.AddProduct;

internal class AddProductHandler : IRequestHandler<AddProductRequest, AddProductResponse>
{
    private readonly IUnitOfWork _uow;
    private readonly IBaseWriteRepository<Domains.Entities.Models.Product> _customerRepository;
    private readonly IMapper _mapper;

    public AddProductHandler(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _customerRepository = _uow.GetWriteRepository<Domains.Entities.Models.Product>();
        _mapper = mapper;
    }

    public async Task<AddProductResponse> Handle(AddProductRequest request, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Domains.Entities.Models.Product>(request);

        await _customerRepository.Create(model);
        await _uow.SaveAsync();

        return new AddProductResponse();
    }
}
