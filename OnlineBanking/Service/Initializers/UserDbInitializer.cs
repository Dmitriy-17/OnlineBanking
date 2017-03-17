using System.Data.Entity;
using OnlineBanking.Models;
using OnlineBanking.Models.Account;

namespace OnlineBanking.Service.Initializers
{
    public class UserDbInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Roles.Add(new Role { Id = 1, Name = "admin" });
            db.Roles.Add(new Role { Id = 2, Name = "user" });
            db.Users.Add(new User
            {
                Id = 1,
                Email = "somemail@gmail.com",
                Password = "123456",
                RoleId = 1
            });
            base.Seed(db);
        }
    }
}