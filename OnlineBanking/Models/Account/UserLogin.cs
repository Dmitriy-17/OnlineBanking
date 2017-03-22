using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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