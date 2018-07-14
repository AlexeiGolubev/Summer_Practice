using Blogs.BLL;
using Blogs.BLL.Interface;
using Blogs.DAL;
using Blogs.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Container
{
    public static class CommentContainer
    {
        public static ICommentDao CommentDao = new CommentDao();
        public static ICommentLogic CommentLogic = new CommentLogic(CommentDao);
    }
}
