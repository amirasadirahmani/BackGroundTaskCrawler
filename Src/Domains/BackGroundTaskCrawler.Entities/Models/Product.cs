
namespace BackGroundTaskCrawler.Domains.Entities.Models;

public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public string? ImageLink { get; set; }
    public decimal? Price { get; set; }
    public string? Dimention { get; set; }
    public float? Weight { get; set; }
}
