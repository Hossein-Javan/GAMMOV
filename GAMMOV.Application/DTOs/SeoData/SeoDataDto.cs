using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.CoreLayer.DTOs.SeoData
{
    public class SeoDataDto
    {
        public int Id { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string OgUrl { get; set; }
        public string OgImg { get; set; }
    }
}
