using GAMMOV.CoreLayer.DTOs.SeoData;

namespace GAMMOV.CoreLayer.DTOs.Tag;

public class CreateTagDto
{
    public string Title { get; set; }
    public string ImageName { get; set; }
    public SeoDataDto SeoData { get; set; }
}