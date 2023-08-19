namespace Week3_Task.Commons
{
    /// <summary>
    /// This specifies the frame of an account
    /// </summary>
    public class Account
    {
        /*Fields*/
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountEmail { get; set; }
        public string AccountPassword { get; set; }
        public string Note { get; set; }
        public double Balance { get; set; } = 0;


    }
}