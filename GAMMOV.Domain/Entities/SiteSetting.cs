using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.DataLayer.Entities
{
    public class SiteSetting
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(250)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(250)]
        public string CopyRight { get; set; }
        [Required]
        [MaxLength(250)]
        public string WebDeveloper { get; set; }
        public SeoData SeoData { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}
