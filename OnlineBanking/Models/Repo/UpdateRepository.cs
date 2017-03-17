using System.Data.Entity;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;

namespace OnlineBanking.Models.Repo
{
    public class UpdateRepository : IUpdateRepository
    {

        protected DbContext mContext;
        public UpdateRepository(DbContext context)
        {
            mContext = context;
        }

        public void Update(IEntity entity)
        {
            var temp = mContext.Set<IEntity>().Find(entity.Id);
            if ((temp != null))
            {
                mContext.Entry(temp).State = EntityState.Modified;
                mContext.SaveChanges();
            }
       
        }
    }
}