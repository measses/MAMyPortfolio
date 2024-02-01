using DataLayer.Abstract;
using DataLayer.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntitiyFramework;

public class EFSkill : GenericRepository<Skill>, ISkill

{
    public EFSkill(AppDbContext context) : base(context)
    {
    }
}   
