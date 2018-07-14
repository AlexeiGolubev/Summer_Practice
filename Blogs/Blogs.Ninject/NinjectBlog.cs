using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogs.BLL;
using Blogs.BLL.Interface;
using Blogs.DAL;
using Blogs.DAL.Interface;
using Ninject;

namespace Blogs.Ninject
{
    public static class NinjectBlog
    {
        #region Fields
        private readonly static IKernel _kernel = new StandardKernel();
        #endregion

        #region Methods
        public static void Resistration()
        {
            _kernel.Bind<IBlogDao>().To<BlogDao>();
            _kernel.Bind<IBlogLogic>().To<BlogLogic>();
        }
        #endregion

        #region Properties
        public static IKernel Kernel => _kernel;
        #endregion
    }
}
