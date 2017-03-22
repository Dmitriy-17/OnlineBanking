using System.Data.Entity;

namespace OnlineBanking.Models.Contract
{
    public interface IDbContextContainer
    {
        DbContext GetDataContext();
        void Store(DbContext dbContext);
    }
}