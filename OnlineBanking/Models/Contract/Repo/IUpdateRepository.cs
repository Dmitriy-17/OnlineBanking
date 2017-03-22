namespace OnlineBanking.Models.Contract.Repo
{
    public interface IUpdateRepository<IEntity>
    {
        void Update(IEntity entity);
    }
}
