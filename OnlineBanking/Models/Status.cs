using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineBanking.Models.Contract;

namespace OnlineBanking.Models
{
    public class Status : IEntity
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
   
        public Status()
        {
            Clients = new List<Client>();
        }
    }
}