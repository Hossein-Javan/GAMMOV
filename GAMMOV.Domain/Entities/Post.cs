using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.DataLayer.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int? PostVisit { get; set; }
        public int UserId { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public SeoData SeoData { get; set; }
        public bool IsSelectedSite { get; set; }
        public bool IsSuggestion { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public User User { get; set; }


    }
}
