using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public int SliceId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string PostText { get; set; }
        public int Comments { get; set; }
        public int Likes { get; set; }
        public int Dislikes{ get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
    }
}
