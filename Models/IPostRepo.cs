using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    public interface IPostRepo
    {
        IEnumerable<Post> GetAllPosts();

        bool addSlice(Post post);

        bool deleteSlice(int postID);

        bool updateSlice(Post post);
    }
}
