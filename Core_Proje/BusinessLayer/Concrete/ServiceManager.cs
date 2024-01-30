using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ServiceManager : IServiceService
{
    private readonly IService _service;

    public ServiceManager(IService service)
    {
        _service = service;
    }

    public List<Service> GetList()
    {
        return _service.GetList();
    }

    public void TAdd(Service entity)
    {
        _service.Insert(entity);
    }

    public void TDelete(Service entity)
    {
        _service.Delete(entity);
    }

    public Service TGetById(int id)
    {
        return _service.GetById(id);
    }

    public void TUpdate(Service entity)
    {
        _service.Update(entity);
    }
}
