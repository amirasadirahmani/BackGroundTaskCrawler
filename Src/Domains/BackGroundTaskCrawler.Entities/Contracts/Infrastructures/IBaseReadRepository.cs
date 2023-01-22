using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackGroundTaskCrawler.Domains.Entities.Contracts.Infrastructures;

public interface IBaseReadRepository<T> where T : class
{
    Task<T> Get(Expression<Func<T, bool>> predict);
    Task<IList<T>> ListAsc(Expression<Func<T, bool>> predict, bool IsTrack, Expression<Func<T, object>> key);
    Task<IList<T>> ListDesc(Expression<Func<T, bool>> predict, bool IsTrack, Expression<Func<T, object>> key);
    Task<IList<T>> PagingListAsc(Expression<Func<T, bool>> predict, bool IsTrack, Expression<Func<T, object>> key, int pageSize, int page);
    Task<IList<T>> PagingListDesc(Expression<Func<T, bool>> predict, bool IsTrack, Expression<Func<T, object>> key, int pageSize, int page);
}

