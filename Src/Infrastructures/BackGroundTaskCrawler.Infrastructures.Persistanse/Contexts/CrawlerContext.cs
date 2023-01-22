
using BackGroundTaskCrawler.Domains.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BackGroundTaskCrawler.Infrastructures.Persistanse.Contexts;

public class CrawlerContext : DbContext
{
    public CrawlerContext(DbContextOptions options) : base(options) { }
    public virtual DbSet<Product> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DipendencyInjection).Assembly);
    }
}
