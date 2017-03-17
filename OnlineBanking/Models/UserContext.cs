using System.Data.Entity;
using OnlineBanking.Models.Account;

namespace OnlineBanking.Models
{
    public class UserContext : DbContext 
    {

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
}