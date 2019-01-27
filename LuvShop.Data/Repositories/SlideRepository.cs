using LuvShop.Data.Infrastructure;
using LuvShop.Model.Models;

namespace LuvShop.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    { }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}