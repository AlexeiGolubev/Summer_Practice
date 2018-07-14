using Blogs.BLL;
using Blogs.BLL.Interface;
using Blogs.DAL;
using Blogs.DAL.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Ninject
{
    public static class NinjectComment
    {
        #region Fields
        private static readonly  IKernel _kernel = new StandardKernel();
        #endregion

        #region Methods
        public static void Resistration()
        {
            _kernel.Bind<ICommentDao>().To<CommentDao>();
            _kernel.Bind<ICommentLogic>().To<CommentLogic>();
        }
        #endregion

        #region Properties
        public static IKernel Kernel => _kernel;
        #endregion
    }
}
