using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public string CreationDate { get; set; }
        public int BlogId { get; set; }
        public string UserName { get; set; }
    }
}
