using System.ComponentModel.DataAnnotations;
using OnlineBanking.Models.Contract;

namespace OnlineBanking.Models.Account
{
    public class User : IEntity
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(40)]

        public string Password { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}