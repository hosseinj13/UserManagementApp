using Microsoft.EntityFrameworkCore;
using MyWinFormsApp.Data;
using MyWinFormsApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyWinFormsApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContextOptions<DatabaseContext> _dbContextOptions;

        public UserRepository(DbContextOptions<DatabaseContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }

      // Method to get all users
        public IEnumerable<User> GetAllUsers()
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                return context.Users.ToList();
            }
        }

       // Method to get a user by ID
        public User GetUserById(int id)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                return context.Users.SingleOrDefault(u => u.Id == id);
            }
        }

       // Method to add new user
        public void CreateUser(User user)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        // Method to update user information
        public void UpdateUser(User user)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }

        // Method to delete user based on ID
        public void DeleteUser(int id)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                var user = context.Users.SingleOrDefault(u => u.Id == id);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }

        // Method to check if the email is duplicated
        public bool IsEmailDuplicate(string email)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                return context.Users.Any(u => u.Email == email);
            }
        }

        // Method to check if the phone number is duplicated
        public bool IsPhoneNumberDuplicate(string phoneNumber)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                return context.Users.Any(u => u.PhoneNumber == phoneNumber);
            }
        }

       // Method to check if username is duplicated
        public bool IsUsernameDuplicate(string username)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                return context.Users.Any(u => u.Username == username);
            }
        }

       // Method to authenticate the user
        public User AuthenticateUser(string usernameOrEmailOrPhone, string password)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                // First, find the user by username, email or phoneNumber
                var user = GetUserByUsernameOrEmailOrPhone(usernameOrEmailOrPhone);

                if (user != null && user.Password == password) 
                {
                    return user;
                }

                return null;
            }
        }

        // Method to get user based on username, email or phoneNumber
        public User GetUserByUsernameOrEmailOrPhone(string usernameOrEmailOrPhone)
        {
            using (var context = new DatabaseContext(_dbContextOptions))
            {
                return context.Users
                    .FirstOrDefault(user => user.Username == usernameOrEmailOrPhone ||
                                            user.Email == usernameOrEmailOrPhone ||
                                            user.PhoneNumber == usernameOrEmailOrPhone);
            }
        }
    }
}
