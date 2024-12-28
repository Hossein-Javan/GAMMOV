using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.DataLayer.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        [Required]
        [MaxLength(60)]
        public string FullName { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public Post Post { get; set; }
    }
}
