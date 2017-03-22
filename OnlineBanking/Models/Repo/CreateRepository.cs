using System.Data.Entity;
using System.Threading.Tasks;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class CreateRepository<T> : BaseRepository, ICreateRepository<T> where T : class, IEntity
    {

        public CreateRepository(DbContext context) : base(context)
        {
        }

        public void Create(T entity)
        {
            mContext.Set<T>().Add(entity);
            mContext.SaveChanges();
        }
    }
}