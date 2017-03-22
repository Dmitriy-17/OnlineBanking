using System;
using System.ComponentModel.DataAnnotations;
using OnlineBanking.Models.Contract;
using OnlineBanking.Service;

namespace OnlineBanking.Models.Account
{
    public class User : IEntity
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [StringLength(30)]
        public string Login { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(40)]
        public string Password { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [ScaffoldColumn(false)]
        public bool IsBlocked { get; set; }

        [ScaffoldColumn(false)]
        public int CountAttemptsToAccess { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

       
    }

   
}