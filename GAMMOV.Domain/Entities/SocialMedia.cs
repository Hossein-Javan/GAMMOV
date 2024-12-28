using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.DataLayer.Entities
{
    public class SocialMedia
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(450)]
        public string Link { get; set; }
        [Required]
        [MaxLength(250)]
        public string Icon { get; set; }
    }
}
