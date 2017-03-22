namespace OnlineBanking.Models.Contract.Repo
{
    public interface IDeleteRepository<T> where T : IEntity
    {
        void Delete(T entity);
    }
}
