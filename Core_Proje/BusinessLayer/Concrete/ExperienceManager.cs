using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ExperienceManager : IExperienceService
{
    private readonly IExperience _experience;

    public ExperienceManager(IExperience experience)
    {
        _experience = experience;
    }

    public void TAdd(Experience entity)
    {
        _experience.Insert(entity);
    }

    public void TDelete(Experience entity)
    {
        _experience.Delete(entity);
    }

    public void TUpdate(Experience entity)
    {
        _experience.Update(entity);
    }

    public List<Experience> GetList()
    {
        return _experience.GetList();
    }

    public Experience TGetById(int id)
    {
        return _experience.GetById(id);
    }




}
