using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BlogDetail:BaseModel
    {
        public string Content { get; set; }
        public string? Content2 { get; set; }
        public string Image { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string Tag { get; set; }
        public ICollection<BlogCategory> BlogCategory { get; set; }






    }
}
