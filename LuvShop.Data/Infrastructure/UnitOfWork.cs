namespace LuvShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        //Commit khi thực hiện, đẩy vào DB. đảm bản transection
        private readonly IDbFactory dbFactory;
        private LuvShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public LuvShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}