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
    public class BlogLogic: IBlogLogic
    {
        private readonly IBlogDao _blogDao;

        #region Constructor

        public BlogLogic(IBlogDao blogDao)
        {
            _blogDao = blogDao;
        }

        #endregion

        #region Methods

        public int AddBlog(Blog blog)
        {
            return _blogDao.AddBlog(blog);
        }

        public void DeleteBlog(int BlogId)
        {
            _blogDao.DeleteBlog(BlogId);
        }

        public void DeleteBlog(string Name)
        {
            _blogDao.DeleteBlog(Name);
        }

        public Blog GetBlog(int BlogId)
        {
            return _blogDao.GetBlog(BlogId);
        }

        public IEnumerable<Blog> GetBlog(string Name)
        {
            return _blogDao.GetBlog(Name);
        }

        public IEnumerable<Blog> GetBlog()
        {
            return _blogDao.GetBlog();
        }

        public IEnumerable<Blog> SortBlogs()
        {
            return _blogDao.SortBlogs();
        }

        public void UpdateBlog(int BlogId, Blog blog)
        {
            _blogDao.UpdateBlog(BlogId, blog);
        }

        public void UpdateBlog(string Name, Blog blog)
        {
            _blogDao.UpdateBlog(Name, blog);
        }
        
        #endregion
    }
}
