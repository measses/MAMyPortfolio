using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class SkillManager : IGenericService<Skill>, ISkillService
{
    private readonly ISkill _skill;

    public SkillManager(ISkill skill)
    {
        _skill = skill;
    }

    public void TAdd(Skill t)
    {
       _skill.Add(t);
    }

    public List<Skill> TGetAll()
    {
        return _skill.GetAll();
    }

    public Skill TGetById(int id)
    {
        return _skill.GetById(id);
    }

    public void TRemove(Skill t)
    {
        _skill.Delete(t);
    }

    public void TUpdate(Skill t)
    {
        _skill.Update(t);
    }
}
