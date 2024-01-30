using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class SocialMediaManager : ISocialMediaService
{
    private readonly ISocialMedia _social;

    public SocialMediaManager(ISocialMedia social)
    {
        _social = social;
    }

    public List<SocialMedia> GetList()
    {
        return _social.GetList();
    }

    public void TAdd(SocialMedia entity)
    {
        _social.Insert(entity);
    }

    public void TDelete(SocialMedia entity)
    {
        _social.Delete(entity);
    }

    public SocialMedia TGetById(int id)
    {
        return _social.GetById(id);
    }

    public void TUpdate(SocialMedia entity)
    {
        _social.Update(entity);
    }
}
