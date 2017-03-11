using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Models.Contract.Repo
{
    interface IReadRepository<T>
    {
        Task<IEntity> GetByIdAsync(int id);
        Task<IEnumerable<IEntity>> GetAllAsync(Func<T, bool> predicate = null);
    }
}
