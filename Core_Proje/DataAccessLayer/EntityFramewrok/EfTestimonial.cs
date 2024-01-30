using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramewrok;

public class EfTestimonial : GenericRepository<Testimonial>, ITestimonial
{
}
