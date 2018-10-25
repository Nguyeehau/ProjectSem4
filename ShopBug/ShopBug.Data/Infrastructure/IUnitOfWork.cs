namespace ShopBug.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}