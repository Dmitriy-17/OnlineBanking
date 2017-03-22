using System;
using System.Data.Entity;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class UpdateRepository<T> : BaseRepository, IUpdateRepository<T> where T : class, IEntity
    {
        public UpdateRepository(DbContext context) : base(context) { }

        public void Update(T entity)
        {
            var temp = mContext.Set<T>().Find(entity.Id);
            if ((temp != null))
            {
                mContext.Entry(entity).State = EntityState.Modified;
                mContext.SaveChanges();
            }
       
        }

       
    }
}