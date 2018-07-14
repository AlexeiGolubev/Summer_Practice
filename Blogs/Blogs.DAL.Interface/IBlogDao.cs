using Blogs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.DAL.Interface
{
    public interface IBlogDao
    {
        int AddBlog(Blog blog);

        void DeleteBlog(int BlogId);

        void DeleteBlog(string Name);

        Blog GetBlog(int BlogId);

        IEnumerable<Blog> GetBlog(string Name);

        IEnumerable<Blog> GetBlog();

        IEnumerable<Blog> SortBlogs();

        void UpdateBlog(int BlogId, Blog blog);

        void UpdateBlog(string Name, Blog blog);

    }
}
