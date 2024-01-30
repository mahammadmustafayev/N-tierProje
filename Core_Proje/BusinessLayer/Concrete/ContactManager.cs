using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ContactManager : IContactService
{
    private readonly IContact _contact;

    public ContactManager(IContact contact)
    {
        _contact = contact;
    }

    public List<Contact> GetList()
    {
        return _contact.GetList();
    }

    public void TAdd(Contact entity)
    {
        _contact.Insert(entity);
    }

    public void TDelete(Contact entity)
    {
        _contact.Delete(entity);
    }

    public Contact TGetById(int id)
    {
        return _contact.GetById(id);
    }

    public void TUpdate(Contact entity)
    {
        _contact.Update(entity);
    }
}
