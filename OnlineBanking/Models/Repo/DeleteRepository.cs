using System.Data.Entity;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class DeleteRepository<T> : IDeleteRepository<T> where T : class, IEntity
    {
        protected DbContext mContext;
        public DeleteRepository(DbContext context)
        {
            mContext = context;
        }
        public void Delete(T entity)
        {
            mContext.Set<T>().Remove(entity);
        }


    }
}