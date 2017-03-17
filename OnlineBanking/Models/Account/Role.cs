using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
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