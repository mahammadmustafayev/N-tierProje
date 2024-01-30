using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class SocialMedia
{
    [Key]
    public int SocialMediaId { get; set; }
    public string SocialMediaName { get; set; }
    public string MediaUrl { get; set; }
    public string Icon { get; set; }
    public bool Status { get; set; }
}
