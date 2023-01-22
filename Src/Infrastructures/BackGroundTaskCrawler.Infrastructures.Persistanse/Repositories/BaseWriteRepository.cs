using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using BackGroundTaskCrawler.Infrastructures.Persistanse.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BackGroundTaskCrawler.Infrastructures.Persistanse.Repositories;
public class BaseWriteRepository<T> : IBaseWriteRepository<T> where T : class
{
    private readonly DbSet<T> _context;

    public BaseWriteRepository(CrawlerContext context)
    {
        _context = context.Set<T>();
    }

    public async Task Create(T model)
    {
        await _context.AddAsync(model);
    }

    public async Task Update(T model)
    {
        _context.Update(model);
    }

    public async Task Delete(Expression<Func<T, bool>> predict)
    {
        var item = await _context.FirstOrDefaultAsync(predict);
        _context.Remove(item);
    }
}
