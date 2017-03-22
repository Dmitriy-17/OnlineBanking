using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBanking.Models.Contract.Repo
{
    public interface IReadRepository<T>
    {
        Task<IEntity> GetByIdAsync(int id);
        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
        T GetFirstOfDefault(Func<T, bool> predicate = null);

    }
}
