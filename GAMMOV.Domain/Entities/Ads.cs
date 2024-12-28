using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMMOV.DataLayer.Entities
{
    public class Ads
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(750)]
        public string Link { get; set; }
        [Required]
        [MaxLength(250)]
        public string Image { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        public Position Position { get; set; }
    }

    public enum Position
    {
        topHeader,
        topRight,
        mainRight,
        buttomRight,
        topLeft,
        mainLeft,
        buttomLeft
    }
}
