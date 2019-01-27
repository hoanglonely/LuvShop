using LuvShop.Data.Infrastructure;
using LuvShop.Model.Models;

namespace LuvShop.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatistic> { }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}