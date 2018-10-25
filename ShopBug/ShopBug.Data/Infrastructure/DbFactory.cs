namespace ShopBug.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopBugDbContext dbContext;

        public ShopBugDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopBugDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}