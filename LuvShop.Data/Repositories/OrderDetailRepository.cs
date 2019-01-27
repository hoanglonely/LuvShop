using LuvShop.Data.Infrastructure;
using LuvShop.Model.Models;

namespace LuvShop.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    { }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}