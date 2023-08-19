namespace Bank.Models
{
    
    /// <summary>
    /// Set the data needed for deposit
    /// </summary>
    public class Deposit
    {
        /*Fields*/
        public double Amount { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Note { get; set; }

    }
}