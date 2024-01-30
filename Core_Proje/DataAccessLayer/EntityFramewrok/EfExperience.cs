using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramewrok;

public class EfExperience : GenericRepository<Experience>, IExperience
{
}
