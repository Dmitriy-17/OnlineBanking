using System.ComponentModel.DataAnnotations;
using OnlineBanking.Models.Contract;

namespace OnlineBanking.Models.Account
{
    public class Role : IEntity
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}