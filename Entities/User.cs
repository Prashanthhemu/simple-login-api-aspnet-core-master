using System;

namespace WebApi.Entities
{
    public class User
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        public DateTime? LogInTime { get; set; }
        public DateTime? LogOutTime { get; set; }
    }
}