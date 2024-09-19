using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonialDal(ApplicationContext context) : base(context)
        {
        }

    }
}