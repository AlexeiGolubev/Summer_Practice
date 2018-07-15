using Blogs.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogs.Entities;
using Blogs.Ninject;
using Blogs.BLL.Interface;
using Ninject;

namespace Blogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //старая версия контейнера
            //var commentLogic = CommentContainer.CommentLogic
            NinjectComment.Resistration();
            var commentLogic = NinjectComment.Kernel.Get<ICommentLogic>();
            //commentLogic.GetAllCommentsByBlogId(1);
            //var id = commentLogic.AddComment(new Comment()
            //{
            //    Text = "Good",
            //    BlogId = 1,
            //    UserName = "Den",
            //});

            foreach (var comment in commentLogic.GetAllCommentsByBlogId(1))
            {
                Console.WriteLine($"{ comment.CommentId} { comment.Text} { comment.CreationDate} { comment.BlogId} { comment.UserName}");
            }
            Console.ReadKey();
        }
    }
}
