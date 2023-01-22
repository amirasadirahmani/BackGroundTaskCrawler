using BackGroundTaskCrawler.EndPoints.Api.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using BackGroundTaskCrawler.EndPoints.Api.Controllers.Common;
using BackGroundTaskCrawler.Applications.Business.UseCases.Product.Commands.AddProduct;
using static BackGroundTaskCrawler.Domains.Entities.Consts.Products.PathConsts;
using BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ProductList;
using BackGroundTaskCrawler.Applications.Business.UseCases.Product.Queries.ShowProduct;

namespace BackGroundTaskCrawler.EndPoints.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost(ProductPathConsts.CreateProduct)]
        [ProducesResponseType(typeof(BaseResponse<AddProductResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BaseResponse<dynamic>), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateProduct([FromBody] AddProductRequest input)
        {
            var response = await _mediator.Send(input);

            return Ok(new BaseResponse<AddProductResponse>(200, true, response));
        }

        [HttpGet(ProductPathConsts.ProductList)]
        [ProducesResponseType(typeof(BaseResponse<ProductListResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BaseResponse<dynamic>), (int)HttpStatusCode.BadRequest)]
        [ResponseCache(Duration = 3)]
        public async Task<IActionResult> ProductList([FromQuery] ProductListRequest input)
        {
            var response = await _mediator.Send(input);

            return Ok(new BaseResponse<ProductListResponse>(200, true, response));
        }

        [HttpGet(ProductPathConsts.ShowProduct)]
        [ProducesResponseType(typeof(BaseResponse<ShowProductResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BaseResponse<dynamic>), (int)HttpStatusCode.BadRequest)]
        [ResponseCache(Duration = 3)]
        public async Task<IActionResult> ShowProduct([FromQuery] ShowProductRequest input)
        {
            var response = await _mediator.Send(input);

            return Ok(new BaseResponse<ShowProductResponse>(200, true, response));
        }

    }
}
