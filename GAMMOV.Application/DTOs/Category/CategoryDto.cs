using GAMMOV.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAMMOV.CoreLayer.DTOs.SeoData;

namespace GAMMOV.CoreLayer.DTOs.Category
{
    public class CategoryDto 
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Icon { get; set; }
        public SeoDataDto SeoData { get; set; }

    }
}
