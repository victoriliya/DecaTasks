namespace Week3_Task.Models
{

    public class Account
    {
        private string accountName;
        private string accountNumber;
        private string accountType;
        private string accountEmail;
        private string accountPassword;
        private string note;
        private double balance;
        
        public Account(string accountName,string accountEmail, string accountNumber, string accountType, string accountPassword
        )
        {
            AccountName = accountName;
            AccountEmail = accountEmail;
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountPassword = accountPassword;
            Balance = 0;
        }

        public string AccountName
        {
            get { return accountName;}
            set { this.accountName = value; }
        }
        
        public string AccountNumber
        {
            get { return accountNumber;}
            set { this.accountNumber = value; }
        }
        
        public string Note
        {
            get { return note;}
            set { this.note = value; }
        }
        
        public double Balance
        {
            get { return balance;}
            set { this.balance = value; }
        }
        
        public string AccountType
        {
            get { return accountType;}
            set { this.accountType = value; }
        }
        
        public string AccountPassword
        {
            get { return accountPassword;}
            set { this.accountPassword = value; }
        }
        
        public string AccountEmail
        {
            get { return accountEmail;}
            set { this.accountEmail = value; }
        }

    }
}