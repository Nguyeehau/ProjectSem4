using System;

namespace ShopBug.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopBugDbContext Init();
    }
}