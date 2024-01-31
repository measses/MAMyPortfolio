using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class About:BaseModel
    {
       
        public required string Description { get; set; }

        public required string Title { get; set; }

        public required string Phone { get; set; }

        public required string Email { get; set; }

        public required string Job { get; set; }

        public required string ImageUrl { get; set; }


    }
}
