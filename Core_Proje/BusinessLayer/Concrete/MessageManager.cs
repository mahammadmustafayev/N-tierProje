using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class MessageManager : IMessageService
{
    private readonly IMessage _message;

    public MessageManager(IMessage message)
    {
        _message = message;
    }

    public List<Message> GetList()
    {
        return _message.GetList();
    }

    public void TAdd(Message entity)
    {
        _message.Insert(entity);
    }

    public void TDelete(Message entity)
    {
        _message.Delete(entity);
    }

    public Message TGetById(int id)
    {
        return _message.GetById(id);
    }

    public void TUpdate(Message entity)
    {
        _message.Update(entity);
    }
}
