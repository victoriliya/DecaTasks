namespace Week3_Task.Commons
{

    public class Account
    {

        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountEmail { get; set; }
        public string AccountPassword { get; set; }
        public string Note { get; set; }
        public double Balance { get; set; }

        public Account(string accountId, string accountName,string accountEmail, string accountNumber, string accountType, string accountPassword
        )
        {
            AccountId = accountId;
            AccountName = accountName;
            AccountEmail = accountEmail;
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountPassword = accountPassword;
            Balance = 0;
        }

        


    }
}