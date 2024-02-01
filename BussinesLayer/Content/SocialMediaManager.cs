using BussinesLayer.Services;
using DataLayer.Abstract;
using DataLayer.EntitiyFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class SocialMediaManager : IGenericService<SocialMedia>
{
    private readonly ISocialMedia _socialMedia;
public SocialMediaManager(ISocialMedia socialMedia)
    {
        _socialMedia = socialMedia;
    }

    public void TAdd(SocialMedia t)
    {
        _socialMedia.Add(t);
    }

    public List<SocialMedia> TGetAll()
    {
        return _socialMedia.GetAll();
    }

    public SocialMedia TGetById(int id)
    {
        return (SocialMedia)_socialMedia.GetById(id);

    }

    public void TRemove(SocialMedia t)
    {
        _socialMedia.Delete(t);
    }

    public void TUpdate(SocialMedia t)
    {
        _socialMedia.Update(t);
    }
}
