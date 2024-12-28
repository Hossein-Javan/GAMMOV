using GAMMOV.CoreLayer.DTOs.SeoData;
using GAMMOV.CoreLayer.DTOs.SocialMedia;
using GAMMOV.DataLayer.Entities;


namespace GAMMOV.CoreLayer.DTOs.SiteSetting
{
    public class SiteSettingDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Logo { get; set; }
        public string CopyRight { get; set; }
        public string WebDeveloper { get; set; }
        public SeoDataDto SeoData { get; set; }
        public SocialMediaDto SocialMedia { get; set; }
    }
}
