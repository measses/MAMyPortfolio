﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Message:BaseModel
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }

    }
}
