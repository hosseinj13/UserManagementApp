using System.Collections.Generic;
using MyWinFormsApp.Models;

namespace MyWinFormsApp.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

        bool IsEmailDuplicate(string email);
        bool IsPhoneNumberDuplicate(string phoneNumber);
        bool IsUsernameDuplicate(string username);

        User GetUserByUsernameOrEmailOrPhone(string usernameOrEmailOrPhone);
    }
}
