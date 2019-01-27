namespace LuvShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private LuvShopDbContext dbContext;

        public LuvShopDbContext Init()
        {
            return dbContext ?? (dbContext = new LuvShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}