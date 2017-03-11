using System;
using System.ComponentModel.DataAnnotations;
using OnlineBanking.Models.Contract;

namespace OnlineBanking.Models
{
    public class Client : IEntity
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Deposit { get; set; }

        public int? StatusId { get; set; }
        public virtual Status Status { get; set; }
    }
}