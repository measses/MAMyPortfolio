using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SocialMedia:BaseModel
    {
        public required string Icon { get; set; }
        public required string Url { get; set; }
    }
}
