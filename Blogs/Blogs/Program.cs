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


            //Block of comment

            //Connection
            //NinjectComment.Resistration();
            //var commentLogic = NinjectComment.Kernel.Get<ICommentLogic>();

            //AddComment
            //var id = commentLogic.AddComment(new Comment()
            //{
            //    Text = "Good",
            //    BlogId = 1,
            //    UserName = "Den",
            //});

            //GetAllCommentsByBlogId
            //foreach (var comment in commentLogic.GetAllCommentsByBlogId(1))
            //{
            //    Console.WriteLine($"{ comment.CommentId} { comment.Text} { comment.CreationDate} { comment.BlogId} { comment.UserName}");
            //}
            //Console.ReadKey();

            ////Block of blog

            //Connection
            //NinjectBlog.Resistration();
            //var blogLogic = NinjectBlog.Kernel.Get<IBlogLogic>();

            //AddBlog
            //var id = blogLogic.AddBlog(new Blog()
            //{
            //    Name = "Test blog",
            //    Description = "New blog",
            //});

            //DeleteBlogById
            /*blogLogic.DeleteBlog(7)*/
            ;

            //DeleteBlogByName
            //blogLogic.DeleteBlog("Test blog");

            ////GetBlogById
            //var blog = blogLogic.GetBlog(2);
            //Console.WriteLine($"{ blog.BlogId} { blog.Name} { blog.CreationDate} { blog.Description}");

            //GetBlogByName
            //foreach (var blog in blogLogic.GetBlog("III"))
            //{
            //    Console.WriteLine($"{ blog.BlogId} { blog.Name} { blog.CreationDate} { blog.Description}");
            //}

            //GetAllBlogs
            //foreach (var blog in blogLogic.GetBlog())
            //{
            //    Console.WriteLine($"{ blog.BlogId} { blog.Name} { blog.CreationDate} { blog.Description}");
            //}

            //SortBlogs
            //foreach (var blog in blogLogic.SortBlogs())
            //{
            //    Console.WriteLine($"{ blog.BlogId} { blog.Name} { blog.CreationDate} { blog.Description}");
            //}

            //GetBlogById
            //blogLogic.UpdateBlog(1, new Blog()
            //{
            //    Name = "Test blog",
            //    Description = "Update blog by Id",
            //});

            //GetBlogByName
            //blogLogic.UpdateBlog("Test blog", new Blog()
            //{
            //    Name = "Test blog",
            //    Description = "Update blog by Name",
            //});


            Console.ReadKey();
        }
    }
}
