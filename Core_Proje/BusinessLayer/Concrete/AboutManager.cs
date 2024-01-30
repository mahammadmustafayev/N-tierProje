using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class AboutManager : IAboutService
{
    private readonly IAbout _about;

    public AboutManager(IAbout about)
    {
        _about = about;
    }

    public List<About> GetList()
    {
        return _about.GetList();
    }

    public void TAdd(About entity)
    {
        _about.Insert(entity);
    }

    public void TDelete(About entity)
    {
        _about.Delete(entity);
    }

    public About TGetById(int id)
    {
        return _about.GetById(id);
    }

    public void TUpdate(About entity)
    {
        _about.Update(entity);
    }
}
