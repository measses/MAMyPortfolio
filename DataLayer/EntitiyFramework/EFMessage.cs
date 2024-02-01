using DataLayer.Abstract;
using DataLayer.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntitiyFramework;

public class EFMessage : GenericRepository<Message>, IMessage
{
    public EFMessage(AppDbContext context) : base(context)
    {
    }
}
