using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(8, 32)]
        public string Name { get; set; }
        [Required]
        [Range(8, 32)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
