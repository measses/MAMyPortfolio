using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact:BaseModel
    {
        public required string Adress { get; set; }
        public required string Phone { get; set; }

        public required string Email { get; set; }
    }
}
