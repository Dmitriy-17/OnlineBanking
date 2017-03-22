using System.Data.Entity;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class DeleteRepository<T> : BaseRepository, IDeleteRepository<T> where T : class, IEntity
    {
        public DeleteRepository(DbContext context) : base(context) { }
        public void Delete(T entity)
        {
            mContext.Set<T>().Remove(entity);
        }


    }
}