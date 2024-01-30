using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class FeatureManager : IFeatureService
{
    private readonly IFeature _feature;

    public FeatureManager(IFeature feature)
    {
        _feature = feature;
    }

    public List<Feature> GetList()
    {
        return _feature.GetList();
    }

    public void TAdd(Feature entity)
    {
        _feature.Insert(entity);
    }

    public void TDelete(Feature entity)
    {
        _feature.Delete(entity);
    }

    public Feature TGetById(int id)
    {
        return _feature.GetById(id);
    }

    public void TUpdate(Feature entity)
    {
        _feature.Update(entity);
    }
}
