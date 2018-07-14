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
    public static class BlogContainer
    {
        public static IBlogDao BlogDao = new BlogDao();
        public static IBlogLogic BlogLogic = new BlogLogic(BlogDao);
    }
}
