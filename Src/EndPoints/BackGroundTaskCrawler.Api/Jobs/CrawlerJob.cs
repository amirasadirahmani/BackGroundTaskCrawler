using BackGroundTaskCrawler.Applications.Business.UseCases.Product.Commands.AddProduct;
using BackGroundTaskCrawler.EndPoints.Api.Model;
using BackGroundTaskCrawler.Infrastructure.Utility.Crawlers;
using BackGroundTaskCrawler.Infrastructures.Persistanse.Migrations;
using MediatR;
using Quartz;

namespace BackGroundTaskCrawler.EndPoints.Api.Jobs
{
    public class CrawlerJob : IJob
    {
        protected readonly IMediator _mediator;

        public CrawlerJob(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            var getList = new LapTopCrawler();
            var productList = getList.startCrawlerasync().Result;
            foreach (var item in productList)
            {
                await _mediator.Send(item);
            }
            Console.WriteLine("CrawlerJob lunch");
        }
    }
}
