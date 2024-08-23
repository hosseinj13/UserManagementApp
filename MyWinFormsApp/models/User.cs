using System.ComponentModel.DataAnnotations.Schema;

namespace MyWinFormsApp.Models
{
    [Table("Users")]  
    
        public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
