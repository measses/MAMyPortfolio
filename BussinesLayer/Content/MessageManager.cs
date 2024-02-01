using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class MessageManager : IGenericService<Message>
{
    private readonly Imessage _message;
public MessageManager(Imessage message)
    {
        _message = message;
    }

    public void TAdd(Message t)
    {
        _message.Add(t);
    }

    public List<Message> TGetAll()
    {
        return _message.GetAll();
    }

    public Message TGetById(int id)
    {
        return (Message)_message.GetById(id);
    }

    public void TRemove(Message t)
    {
        
    }

    public void TUpdate(Message t)
    {
        throw new NotImplementedException();
    }
}
