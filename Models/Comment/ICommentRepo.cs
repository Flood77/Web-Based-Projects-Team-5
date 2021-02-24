using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    interface ICommentRepo
    {
        IEnumerable<Comment> GetAllComments();

        bool addComment(Comment comment);

        bool deleteComment(int commentID);

        bool updateComment(Comment comment);
    }
}
