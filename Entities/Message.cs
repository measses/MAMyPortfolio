using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Message:BaseModel
    {
        public required string Email { get; set; }
        public required string Subject { get; set; }
        public required string Text { get; set; }

    }
}
