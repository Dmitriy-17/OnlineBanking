using System.ComponentModel.DataAnnotations;

namespace OnlineBanking.Models.Account
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(40)]
        public string Email { get; set; }
        [StringLength(40)]
        public string Password { get; set; }
    }
}