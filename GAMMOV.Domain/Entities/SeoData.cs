using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.DataLayer.Entities
{
    public class SeoData
    {
        public int Id { get; set; }
        [Required]
        [MinLength(50)]
        [MaxLength(180)]
        public string MetaDescription { get; set; }
        [Required]
        [MaxLength(180)]
        public string MetaTitle { get; set; }
        [MaxLength(450)]
        public string OgUrl { get; set; }
        [MaxLength(250)]
        public string OgImg { get; set; }

      
    }
}
