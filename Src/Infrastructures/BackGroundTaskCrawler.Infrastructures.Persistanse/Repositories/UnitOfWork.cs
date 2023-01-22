using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;

namespace BackGroundTaskCrawler.Infrastructures.Persistanse.Repositories;
public class UnitOfWork : IUnitOfWork
{
    private readonly Contexts.CrawlerContext _context;

    public UnitOfWork(Contexts.CrawlerContext context)
    {
        _context = context;
    }

    public IBaseReadRepository<T> GetReadRepository<T>() where T : class
    => new BaseReadRepository<T>(_context);

    public IBaseWriteRepository<T> GetWriteRepository<T>() where T : class
        => new BaseWriteRepository<T>(_context);

    public async Task SaveAsync()
        => await _context.SaveChangesAsync();
}
