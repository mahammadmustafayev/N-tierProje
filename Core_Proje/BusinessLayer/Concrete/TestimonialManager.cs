using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonial _testimonail;

    public TestimonialManager(ITestimonial testimonail)
    {
        _testimonail = testimonail;
    }

    public List<Testimonial> GetList()
    {
        return _testimonail.GetList();
    }

    public void TAdd(Testimonial entity)
    {
        _testimonail.Insert(entity);
    }

    public void TDelete(Testimonial entity)
    {
        _testimonail.Delete(entity);
    }

    public Testimonial TGetById(int id)
    {
        return _testimonail.GetById(id);
    }

    public void TUpdate(Testimonial entity)
    {
        _testimonail.Update(entity);
    }
}
