using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class DeleteRepository : IDeleteRepository<IEntity>
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}