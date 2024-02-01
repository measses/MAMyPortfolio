using DataLayer.Abstract;
using DataLayer.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntitiyFramework;

public class EFWork : GenericRepository<Work>, IWork
{
    public EFWork(AppDbContext context) : base(context)
    {
    }
}
