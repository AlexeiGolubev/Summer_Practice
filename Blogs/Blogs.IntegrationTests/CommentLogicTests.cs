using System;
using Blogs.Ninject;
using Ninject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blogs.BLL.Interface;
using Blogs.Entities;
using Blogs;
using System.Linq;

namespace Blogs.IntegrationTests
{
    [TestClass]
    public class CommentLogicTests
    {
        [TestMethod]
        public void AddComment()
        {
            NinjectComment.Resistration();
            var commentLogic = NinjectComment.Kernel.Get<ICommentLogic>();

            var newComment = new Comment()
            {
                Text = "Good",
                BlogId = 1,
                UserName = "Den",
            };

            var newCommentId = commentLogic.AddComment(newComment);
            var commentDB = new Comment();

            foreach (var comment in commentLogic.GetAllCommentsByBlogId(newComment.BlogId))
            {
                if (comment.CommentId == newCommentId)
                {
                    commentDB = comment;
                    break;
                }
            }
            Assert.IsNotNull(commentDB, "Last blog is null");
            Assert.AreEqual(newComment.Text, commentDB.Text, "Text Comment is not equal");
            Assert.AreEqual(newComment.BlogId, commentDB.BlogId, "BlogId Comment is not equal");
            Assert.AreEqual(newComment.UserName, commentDB.UserName, "UserName Comment is not equal");
        }

        [TestMethod]
        public void GetAllCommentsByBlogId()
        {
            NinjectComment.Resistration();
            var commentLogic = NinjectComment.Kernel.Get<ICommentLogic>();

            var newComment = new Comment()
            {
                Text = "Good",
                BlogId = 3,
                UserName = "Den",
            };

            var newCommentId = commentLogic.AddComment(newComment);
            var commentDB = commentLogic.GetAllCommentsByBlogId(newComment.BlogId).ToList();
            
            Assert.IsNotNull(commentDB);
            Assert.AreEqual(commentDB.Count, 1);
        }
    }
}
