using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
        public string Description { get; set; }
    }
}
