using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.DataLayer.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(250)]
        public string ImageName { get; set; }
        public SeoData SeoData { get; set; }
        public ICollection<Post> Posts { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
