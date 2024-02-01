using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class ServiceManager : IGenericService<Service>, IServiceService
{
    private readonly IService _service;
    public ServiceManager(IService service)
    {
        _service = service;
    }

    public void TAdd(Service t)
    {
        _service.Add(t);
    }

    public List<Service> TGetAll()
    {
        return _service.GetAll();
    }

    public Service TGetById(int id)
    {
        return (Service)_service.GetById(id);
    }

    public void TRemove(Service t)
    {
        _service.Delete(t);
    }

    public void TUpdate(Service t)
    {
        _service.Update(t);
    }
}
