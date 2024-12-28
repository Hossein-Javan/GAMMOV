using GAMMOV.CoreLayer.DTOs.SeoData;

namespace GAMMOV.CoreLayer.DTOs.Post;

public class CreatePostDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public SeoDataDto SeoData { get; set; }
    public bool IsSelectedSite { get; set; }
    public bool IsSuggestion { get; set; }
        
}