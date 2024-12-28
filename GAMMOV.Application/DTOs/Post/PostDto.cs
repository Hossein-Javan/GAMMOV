using GAMMOV.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAMMOV.CoreLayer.DTOs.SeoData;

namespace GAMMOV.CoreLayer.DTOs.Post
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public SeoDataDto SeoData { get; set; }
        public bool IsSelectedSite { get; set; }
        public bool IsSuggestion { get; set; }

    }
}
