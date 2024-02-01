using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BussinesLayer.Content;

public class AboutManager : IGenericService<About>, IAboutService
{
    private readonly IAbout _about;

    public AboutManager(IAbout about)
    {
        _about = about;
    }

    public void TAdd(About t)
    {
       _about.Add(t);
    }

    public List<About> TGetAll()
    {
        return _about.GetAll();
    }

    public About TGetById(int id)
    {
        return _about.GetById(id);
    }

    public void TRemove(About t)
    {
        _about.Delete(t);
    }

    public void TUpdate(About t)
    {
      _about.Update(t);
    }
}
