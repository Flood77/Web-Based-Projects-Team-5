using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    public class Comment
    {
        int ID;
        int PostID;
        int UserID;
        int ParentCommentID;
        string Text;
        int Likes;
        int Dislikes;
    }
}
