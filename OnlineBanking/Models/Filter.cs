using OnlineBanking.Models.Contract;

namespace OnlineBanking.Models
{
    public class Filter : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? StatusId { get; set; }
    }
}