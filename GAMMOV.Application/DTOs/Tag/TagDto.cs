using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAMMOV.CoreLayer.DTOs.SeoData;

namespace GAMMOV.CoreLayer.DTOs.Tag
{
    public class TagDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public SeoDataDto SeoData { get; set; }
    }
}
