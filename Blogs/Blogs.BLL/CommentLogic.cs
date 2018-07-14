using Blogs.BLL.Interface;
using Blogs.DAL.Interface;
using Blogs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.BLL
{
    public class CommentLogic : ICommentLogic
    {
        private readonly ICommentDao _commentDao;

        #region Constructor

        public CommentLogic(ICommentDao commentDao)
        {
            _commentDao = commentDao;
        }

        #endregion

        #region Methods

        public int AddComment(Comment comment)
        {
            return _commentDao.AddComment(comment);
        }

        public IEnumerable<Comment> GetAllCommentsByBlogId(int BlogId)
        {
            return _commentDao.GetAllCommentsByBlogId(BlogId);
        }

        #endregion
    }
}
