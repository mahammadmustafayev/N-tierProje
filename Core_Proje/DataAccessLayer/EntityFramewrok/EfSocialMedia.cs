using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramewrok;

public class EfSocialMedia : GenericRepository<SocialMedia>, ISocialMedia
{
}
