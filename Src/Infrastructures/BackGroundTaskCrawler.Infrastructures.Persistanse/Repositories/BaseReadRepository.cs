using BackGroundTaskCrawler.Infrastructures.Persistanse.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;
using BackGroundTaskCrawler.Infrastructures.Persistanse.Contexts;

namespace BackGroundTaskCrawler.Infrastructures.Persistanse.Repositories;
public class BaseReadRepository<T>:IBaseReadRepository<T> where T : class
{
    private readonly DbSet<T> _context;

    public BaseReadRepository(CrawlerContext context)
    {
        _context = context.Set<T>();
    }


    public async Task<IList<T>> PagingListAsc(Expression<Func<T, bool>> predict, bool IsTrack, Expression<Func<T, object>> key, int pageSize, int page)
    {
        var query = _context.Where(predict);
        if (!IsTrack)
            query = query.AsNoTracking();

        query.OrderBy(key).Skip((page - 1) * pageSize).Take(pageSize);

        return await query.ToListAsync();
    }

    public async Task<IList<T>> PagingListDesc(Expression<Func<T, bool>> predict, bool IsTrack, Expression<Func<T, object>> key, int pageSize, int page)
    {
        var query = _context.Where(predict);
        if (!IsTrack)
            query = query.AsNoTracking();

        query.OrderByDescending(key).Skip((page - 1) * pageSize).Take(pageSize);

        return await query.ToListAsync();
    }

    public async Task<IList<T>> ListAsc(Expression<Func<T, bool>> predict, bool IsTrack, Expression<Func<T, object>> key)
    {
        var query = _context.Where(predict);
        if (!IsTrack)
            query = query.AsNoTracking();

        query.OrderBy(key);

        return await query.ToListAsync();
    }

    public async Task<IList<T>> ListDesc(Expression<Func<T, bool>> predict, bool IsTrack, Expression<Func<T, object>> key)
    {
        var query = _context.Where(predict);
        if (!IsTrack)
            query = query.AsNoTracking();

        query.OrderByDescending(key);

        return await query.ToListAsync();
    }

    public async Task<T> Get(Expression<Func<T, bool>> predict) => await _context.FirstOrDefaultAsync(predict);

}
