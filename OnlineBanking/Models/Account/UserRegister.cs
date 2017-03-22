using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OnlineBanking.Service;

namespace OnlineBanking.Models.Account
{
    public class UserRegister
    {
        [StringLength(30)]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [StringLength(30)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [StringLength(40)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(40)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        public bool IsValid()
        {
            if (!Login.InRange(3, 30))
            {
                Logger.Log.ErrorFormat("Login invalid");
                return false;
            }
            if (!Name.InRange(3, 30))
            {
                Logger.Log.ErrorFormat("Name invalid");
                return false;
            }
            if (!Email.IsEmail())
            {
                Logger.Log.ErrorFormat("Email invalid");
                return false;
            }
            if (!Password.InRange(4, 40))
            {
                Logger.Log.ErrorFormat("Password invalid");
                return false;
            }
            return true;
        }
    }
}