using Blogs.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogs.Entities;

namespace Blogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var commentLogic = CommentContainer.CommentLogic;
            //commentLogic.GetAllCommentsByBlogId(1);

            foreach (var comment in commentLogic.GetAllCommentsByBlogId(1))
            {
                Console.WriteLine($"{ comment.CommentId} { comment.Text} { comment.CreationDate} { comment.BlogId} { comment.UserName}");
            }
            Console.ReadKey();
        }
    }
}
