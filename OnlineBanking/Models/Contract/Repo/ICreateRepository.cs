namespace OnlineBanking.Models.Contract.Repo
{
    public interface ICreateRepository<IEntity>
    {
        void Create(IEntity entity);

    }
}
