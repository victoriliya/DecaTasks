namespace Week3_Task.Models
{
    public class Customer 
    {
        private string firstname;
        private string surname;
        private string email;
        private string password;
        private Account account;
        private string accountNumber;
        private string accountType;
        public string Firstname
        {
            get { return firstname;}
            set { this.firstname = value; }
        }
        
        public string Surname
        {
            get { return surname;}
            set { this.surname = value; }
        }

        public string Email
        {
            get { return email;}
            set { this.email = value; }
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }
        
        public string AccountType
        {
            get { return accountType; }
            set { this.accountType = value; }
        }
        
        public string AccountNumber
        {
            get { return accountNumber; }
            set { this.accountNumber = value; }
        }

    }
}