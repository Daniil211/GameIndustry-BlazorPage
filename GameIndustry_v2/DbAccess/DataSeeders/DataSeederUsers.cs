using Application.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Persistence.DataSeeders
{
    public class DataSeederUsers
    {
        public static ModelBuilder SeedData(ModelBuilder modelBuilder)
        {
            List<Role> Roles = new()
            {
                new()
                {
                    Id = 1,
                    Name = "Admin"
                },
                new()
                {
                    Id = 2,
                    Name = "User"
                }
            };

            List<User> Users = new()
            {
                new()
                {
                    Id = 1,
                    Username = "User1",
                    Password = "User1",
                    Age = 19,
                    IsPremiumMember = false
                },
                new()
                {
                    Id = 2,
                    Username = "User2",
                    Password = "User2",
                    Age = 10,
                    IsPremiumMember = true
                },
                new()
                {
                    Id = 3,
                    Username = "User3",
                    Password = "User3",
                    Age = 20,
                    IsPremiumMember = true
                }
            };

            List<UsersRole> UsersRoles = new()
            {
                new()
                {
                    Id = 1,
                    UserId = Users[0].Id,
                    RoleId = Roles[0].Id
                },
                new()
                {
                    Id = 2,
                    UserId = Users[0].Id,
                    RoleId = Roles[1].Id
                },
                new()
                {
                    Id = 3,
                    UserId = Users[1].Id,
                    RoleId = Roles[1].Id
                },
            };

            modelBuilder.Entity<Role>().HasData(Roles);
            modelBuilder.Entity<User>().HasData(Users);
            modelBuilder.Entity<UsersRole>().HasData(UsersRoles);

            return modelBuilder;
        }
    }
}