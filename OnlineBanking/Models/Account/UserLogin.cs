using System.ComponentModel.DataAnnotations;

namespace OnlineBanking.Models.Account
{
    public class UserLogin
    {
        [StringLength(30)]
        public string Login { get; set; }

        [StringLength(40)]
        public string Password { get; set; }
    }
}