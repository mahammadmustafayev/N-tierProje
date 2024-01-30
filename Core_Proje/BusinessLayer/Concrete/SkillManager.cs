using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class SkillManager : ISkillService
{
    private readonly ISkill _skill;

    public SkillManager(ISkill skill)
    {
        _skill = skill;
    }

    public List<Skill> GetList()
    {
        return _skill.GetList();
    }

    public void TAdd(Skill entity)
    {
        _skill.Insert(entity);
    }

    public void TDelete(Skill entity)
    {
        _skill.Delete(entity);
    }

    public Skill TGetById(int id)
    {
        return _skill.GetById(id);
    }

    public void TUpdate(Skill entity)
    {
        _skill.Update(entity);
    }
}
