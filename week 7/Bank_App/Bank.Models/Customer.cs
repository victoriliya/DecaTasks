using System;

namespace Week3_Task.Commons
{

    /// <summary>
    /// Sets the customers skeleton
    /// </summary>
    public class Customer 
    {
        /*Fields*/
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Account Account { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

      

    }
}