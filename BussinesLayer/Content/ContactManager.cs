using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class ContactManager : IGenericService<Contact>, IContactService
{
    private readonly IContact _contact;

    public ContactManager(IContact contact)
    {
        _contact = contact;
    }

    public void TAdd(Contact t)
    {
        _contact.Add(t);
    }

    public List<Contact> TGetAll()
    {
        return _contact.GetAll();
    }

    public Contact TGetById(int id)
    {
        return (Contact)_contact.GetById(id);
    }

    public void TRemove(Contact t)
    {
        _contact.Delete(t);
    }

    public void TUpdate(Contact t)
    {
        _contact.Update(t);
    }
}
