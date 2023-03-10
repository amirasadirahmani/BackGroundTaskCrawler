// <auto-generated />
using BackGroundTaskCrawler.Infrastructures.Persistanse.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackGroundTaskCrawler.Infrastructures.Persistanse.Migrations
{
    [DbContext(typeof(CrawlerContext))]
    [Migration("20230122082749_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BackGroundTaskCrawler.Domains.Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Dimention")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(12,0)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("ProductId");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
