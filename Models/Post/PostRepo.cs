using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models.Post
{
    public class PostRepo : IPostRepo
    {
        public bool addPost(Post post)
        {
            return true;
        }

        public bool deletePost(int postID)
        {
            return true;
        }

        public IEnumerable<Post> GetAllPosts(string table, int id)
        {
            return new List<Post>();
        }

        public bool updatePost(Post post)
        {
            return true;
        }
    }
}
