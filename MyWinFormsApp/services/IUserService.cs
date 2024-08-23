using System.Collections.Generic;
using MyWinFormsApp.Models;

namespace MyWinFormsApp.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

        User ValidateUser(string identifier, string password);
    }
}
