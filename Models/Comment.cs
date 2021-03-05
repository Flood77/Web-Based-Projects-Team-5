using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Breaddit.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public int? ParentComment { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }
    }
}
