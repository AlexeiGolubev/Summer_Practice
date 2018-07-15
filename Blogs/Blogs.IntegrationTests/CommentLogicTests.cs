using System;
using Blogs.Ninject;
using Ninject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blogs.BLL.Interface;
using Blogs.Entities;
using Blogs;

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

            var IdnewComment = commentLogic.AddComment(newComment);
            var commentDB = new Comment();

            foreach (var comment in commentLogic.GetAllCommentsByBlogId(1))
            {
                if (comment.CommentId == IdnewComment)
                {
                    commentDB = comment;
                    break;
                }
            }
            Assert.AreEqual(newComment.Text, commentDB.Text, "Text Comment is not equal");
            Assert.AreEqual(newComment.BlogId, commentDB.BlogId, "BlogId Comment is not equal");
            Assert.AreEqual(newComment.UserName, commentDB.UserName, "UserName Comment is not equal");
        }
    }
}
