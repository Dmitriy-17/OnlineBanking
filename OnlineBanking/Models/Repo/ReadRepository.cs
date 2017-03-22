using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class ReadRepository<T> : BaseRepository, IReadRepository<T> where T : class, IEntity 
    {
        public ReadRepository(DbContext context) : base(context) { }

        public async Task<IEntity> GetByIdAsync(int id)
        {
            return await mContext.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate == null)
            {
                return mContext.Set<T>().ToList();
            }
            var result = mContext.Set<T>().Where(predicate);
            return result;
        }

        public T GetFirstOfDefault(Func<T, bool> predicate)
        {
            if (predicate != null)
            {
                return mContext.Set<T>().FirstOrDefault(predicate);
            }
            return null;
        }
    }
}