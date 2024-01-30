using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Portfolio
{
    [Key]
    public int PortfolioId { get; set; }
    public string PortfolioName { get; set; }
    public string ImageUrl { get; set; }
}
