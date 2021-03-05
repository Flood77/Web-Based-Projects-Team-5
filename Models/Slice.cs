using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    public class Slice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Range(0, int.MaxValue)]
        public int Followers { get; set; }
        [ReadOnly(true)]
        public int UserId { get; set; }
    }
}
