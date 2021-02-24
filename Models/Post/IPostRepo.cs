using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    public interface IPostRepo
    {
        IEnumerable<Post> GetAllPosts(string table, int id);

        bool addPost(Post post);

        bool deletePost(int postID);

        bool updatePost(Post post);
    }
}
