using System;
using System.Text.RegularExpressions;

namespace MyWinFormsApp.Utils
{
    public static class Validation
    {
        public static bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Regular expression for validating an Email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Regular expression for validating a Phone Number
            string phonePattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        public static bool IsPasswordStrong(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                return false;

            // Regular expression for validating a Strong Password (at least 8 characters, one uppercase letter, one lowercase letter, and one digit)
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        public static bool IsUsernameValid(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 5)
                return false;

            // Regular expression for validating a Username (at least 5 characters, no special characters)
            string usernamePattern = @"^[a-zA-Z0-9]{5,}$";
            return Regex.IsMatch(username, usernamePattern);
        }

        public static bool IsNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // Regular expression for validating a Name (only alphabets)
            string namePattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(name, namePattern);
        }
    }
}
