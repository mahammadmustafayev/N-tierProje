using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Experience
{
    [Key]
    public int ExperienceId { get; set; }
    public string ExperienceName { get; set; }
    public string Date { get; set; }
    public string ImageUrl { get; set; }
    public int Description { get; set; }
}
