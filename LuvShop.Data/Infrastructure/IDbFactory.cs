using System;

namespace LuvShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        LuvShopDbContext Init();
    }
}