using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class About:BaseModel
    {
       
        public string Description { get; set; }

        public string Title { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Job { get; set; }

        public string ImageUrl { get; set; }


    }
}
