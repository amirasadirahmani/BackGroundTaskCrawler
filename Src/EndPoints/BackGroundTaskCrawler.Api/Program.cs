using BackGroundTaskCrawler.Applications.Business;
using BackGroundTaskCrawler.Domains.Entities;
using BackGroundTaskCrawler.EndPoints.Api;
using BackGroundTaskCrawler.EndPoints.Api.Jobs.Extentions;
using BackGroundTaskCrawler.Infrastructures.Persistanse;
using Quartz;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<BackGroundTaskCrawler.EndPoints.Api.Filters.FluentValidationFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddQuartz(config =>
{
    config.UseMicrosoftDependencyInjectionScopedJobFactory();

    config.AddJobAndTrigger<BackGroundTaskCrawler.EndPoints.Api.Jobs.CrawlerJob>(builder.Configuration);
});

builder.Services.AddQuartzHostedService(config => config.WaitForJobsToComplete = true);

builder.Services.AddDomain();
builder.Services.AddApplication();
builder.Services.AddPresistance(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseMiddleware<GlobalExceptionMiddleware>();

app.MapControllers();
app.Run();
