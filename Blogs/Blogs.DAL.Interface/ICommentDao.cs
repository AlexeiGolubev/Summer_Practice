using Blogs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.DAL.Interface
{
    public interface ICommentDao
    {
        int AddComment(Comment comment);

        IEnumerable<Comment> GetAllCommentsByBlogId(int BlogId);

    }
}
