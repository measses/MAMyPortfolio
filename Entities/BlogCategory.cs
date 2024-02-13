using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BlogCategory:BaseModel
    {
        public ICollection<BlogDetail> BlogDetails { get; set; }
    }
}
