using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class ReadRepository : IReadRepository<T>
    {
        public Task<IEnumerable<IEntity>> GetAllAsync(Func<T, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}