using LuvShop.Data.Infrastructure;
using LuvShop.Model.Models;

namespace LuvShop.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    { }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}