using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Skill : BaseModel
{
    public int Value { get; set; }
    public string? Description { get; set; }
}
