using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Models.Contract.Repo
{
    interface ICreateRepository<T>
    {
        Task<IEntity> CreateAsync(IEntity entity);

    }
}
