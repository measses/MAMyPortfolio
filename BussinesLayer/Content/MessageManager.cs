using BussinesLayer.Services;
using DataLayer.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Content;

public class MessageManager : IGenericService<Message>, IMessageService
{
    private readonly IMessage _message;
public MessageManager(IMessage message)
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
        _message.Delete(t);
    }

    public void TUpdate(Message t)
    {
        _message.Update(t);
    }
}
