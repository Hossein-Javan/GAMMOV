using GAMMOV.DataLayer.Entities;

namespace GAMMOV.CoreLayer.DTOs.Ads;

public class CreateAdsDto
{
    public bool IsActive { get; set; }
    public string Name { get; set; }
    public string Link { get; set; }
    public string Image { get; set; }
    public DateTime ExpireDate { get; set; }
    public Position Position { get; set; }
}