using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineBanking.Models
{
    public class Context : DbContext 
    {

        public DbSet<Client> Clients { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}