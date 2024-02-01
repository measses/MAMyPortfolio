using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class WorkManager : IGenericService<Work>
{
    private readonly IWork _work;

    public WorkManager(IWork work)
    {
        _work = work;
    }

    public void TAdd(Work t)
    {
        _work.Add(t);
    }

    public List<Work> TGetAll()
    {
        return _work.GetAll();
    }

    public Work TGetById(int id)
    {
        return (Work)_work.GetById(id);
    }

    public void TRemove(Work t)
    {
        _work.Delete(t);
    }

    public void TUpdate(Work t)
    {
        _work.Update(t);
    }
}
