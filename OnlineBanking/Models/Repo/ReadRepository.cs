using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;
using System.Data.Entity;
using System.Linq.Expressions;

namespace OnlineBanking.Models.Repo
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntity 
    {
        protected DbContext mContext;
        public ReadRepository(DbContext context)
        {
            mContext = context;
        }

        public async Task<IEntity> GetByIdAsync(int id)
        {
            return await mContext.Set<T>().FindAsync(id);
        }

        public IEnumerable<IEntity> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate == null)
            {
                return mContext.Set<T>().ToList();
            }
            var result = mContext.Set<T>().Where(predicate).ToList();
            return result;
        }
    }
}