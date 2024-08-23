using System.Collections.Generic;
using MyWinFormsApp.Models;
using MyWinFormsApp.Repositories;
using MyWinFormsApp.Utils;

namespace MyWinFormsApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public void CreateUser(User user)
        {
            // Check if the email is duplicated
            if (_userRepository.IsEmailDuplicate(user.Email))
            {
                throw new System.Exception("This email is already in use.");
            }

            // Checking whether the phone number is duplicated
            if (_userRepository.IsPhoneNumberDuplicate(user.PhoneNumber))
            {
                throw new System.Exception("This phone number is already in use.");
            }

           // Check if the username is duplicated
            if (_userRepository.IsUsernameDuplicate(user.Username))
            {
                throw new System.Exception("This username is already in use.");
            }

            // Check if the password is strong
            if (!Validation.IsPasswordStrong(user.Password))
            {
                throw new System.Exception("Password is not strong enough.");
            }

            _userRepository.CreateUser(user);
        }

        public void UpdateUser(User user)
        {
           // Check if the email is duplicated (except for the current user)
            if (
                _userRepository.IsEmailDuplicate(user.Email)
                && _userRepository.GetUserById(user.Id)?.Email != user.Email
            )
            {
                throw new System.Exception("This email is already in use.");
            }

            // checking whether the phone number is duplicated (except for the current user)
            if (
                _userRepository.IsPhoneNumberDuplicate(user.PhoneNumber)
                && _userRepository.GetUserById(user.Id)?.PhoneNumber != user.PhoneNumber
            )
            {
                throw new System.Exception("This phone number is already in use.");
            }

           // Check if the username is duplicated (except for the current user)
            if (
                _userRepository.IsUsernameDuplicate(user.Username)
                && _userRepository.GetUserById(user.Id)?.Username != user.Username
            )
            {
                throw new System.Exception("This username is already in use.");
            }

            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public User ValidateUser(string identifier, string password)
        {
            var user = _userRepository.GetUserByUsernameOrEmailOrPhone(identifier);

            if (user != null && user.Password == password)
            {
                return user;
            }

            return null;
        }

    }
}
