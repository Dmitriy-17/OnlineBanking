using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnlineBanking.Models.Contract;

namespace OnlineBanking.Models
{
    public class Status : IEntity
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public  string Name { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
   
        public Status()
        {
            Clients = new List<Client>();
        }
    }
}