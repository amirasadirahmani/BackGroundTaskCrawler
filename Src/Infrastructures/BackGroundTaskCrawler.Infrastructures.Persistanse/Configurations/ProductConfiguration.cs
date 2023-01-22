using BackGroundTaskCrawler.Domains.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BackGroundTaskCrawler.Infrastructures.Persistanse.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public virtual void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .HasKey(p => p.ProductId);

        builder
            .Property(p => p.ProductName)
            .HasColumnType("nvarchar(128)")
            .IsRequired(false);
        
        builder
            .Property(p => p.Dimention)
            .HasColumnType("varchar(64)")
            .IsRequired(false);


        builder
            .Property(p => p.Price)
            .HasColumnType("decimal(12,0)")
            .IsRequired(false);


        builder
            .Property(p => p.ImageLink)
            .HasColumnType("nvarchar(500)")
            .IsRequired(false);


        builder
            .Property(p => p.Weight)
            .IsRequired(false);

    }
}
