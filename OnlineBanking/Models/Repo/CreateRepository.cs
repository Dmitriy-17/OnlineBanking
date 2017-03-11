using System.Data.Entity;
using System.Threading.Tasks;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class CreateRepository<TEntity> : ICreateRepository<IEntity> where TEntity : class
    {
        protected DbContext mContext;

        public CreateRepository(DbContext context)
        {
            mContext = context;
        }

        public Task<IEntity> CreateAsync(IEntity entity)
        {
            mContext.Set<TEntity>().Where();
            //throw new NotImplementedException();
        }
    }
}