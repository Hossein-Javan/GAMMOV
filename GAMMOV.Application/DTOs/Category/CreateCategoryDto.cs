using GAMMOV.CoreLayer.DTOs.SeoData;

namespace GAMMOV.CoreLayer.DTOs.Category;

public class CreateCategoryDto 
{
    public int? ParentId { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public string Icon { get; set; }
    public CreateSeoDataDto SeoData { get; set; }
   
}