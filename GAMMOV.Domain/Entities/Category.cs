using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.DataLayer.Entities
{
    public class Category 
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string Slug { get; set; }
        [Required]
        [MaxLength(150)]
        public string Icon { get; set; }
        public SeoData SeoData { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }
}
