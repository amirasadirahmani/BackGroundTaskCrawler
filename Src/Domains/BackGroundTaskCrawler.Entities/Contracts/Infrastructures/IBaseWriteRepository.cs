namespace BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;

public interface IBaseWriteRepository<T> where T : class
{
    Task Create(T model);
}
