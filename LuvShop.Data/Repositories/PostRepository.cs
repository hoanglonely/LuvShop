using LuvShop.Data.Infrastructure;
using LuvShop.Model.Models;

namespace LuvShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    { }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}