using System;
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
                Name = "AdminName",
                Login = "admin",
                Email = "admin@gmail.com",
                Password = "123456",
                RoleId = 1
            });
            db.Statuses.Add(new Status { Id = 1, Name = "VIP" });
            db.Statuses.Add(new Status { Id = 2, Name = "Classic" });

            db.Clients.Add(new Client
            {
                StatusId = 1,
                Phone = "0965842168",
                ContractNumber = "0124569",
                DateOfBirth = DateTime.Now,
                FirstName = "Fname1",
                LastName = "LName1",
                Deposit = true

            });
            db.Clients.Add(new Client
            {
                StatusId = 1,
                Phone = "0965762168",
                ContractNumber = "0464569",
                DateOfBirth = DateTime.Now,
                FirstName = "Fname2",
                LastName = "LName2",
                Deposit = false
            });
            db.Clients.Add(new Client
            {
                StatusId = 2,
                Phone = "0906842168",
                ContractNumber = "0467369",
                DateOfBirth = DateTime.Now,
                FirstName = "Fname3",
                LastName = "LName3",
                Deposit = true
            });

            base.Seed(db);
        }
    }
}