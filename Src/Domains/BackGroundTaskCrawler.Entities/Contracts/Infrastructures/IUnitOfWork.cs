
namespace BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;

public interface IUnitOfWork
{
    IBaseReadRepository<T> GetReadRepository<T>() where T : class;
    IBaseWriteRepository<T> GetWriteRepository<T>() where T : class;
    Task SaveAsync();
}
