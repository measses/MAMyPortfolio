using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Portfolio:BaseModel
{
    public required string Filter { get; set; }
    public string ImageUrl { get; set; }
    public string ProjectUrl { get; set; }

}
