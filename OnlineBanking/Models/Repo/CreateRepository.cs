using System.Data.Entity;
using System.Threading.Tasks;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class CreateRepository<T> : ICreateRepository<T> where T : class, IEntity
    {
        protected DbContext mContext;

        public CreateRepository(DbContext context)
        {
            mContext = context;
        }

        public  void CreateAsync(T entity)
        {
            mContext.Set<T>().Add(entity);
            mContext.SaveChanges();
        }
    }
}