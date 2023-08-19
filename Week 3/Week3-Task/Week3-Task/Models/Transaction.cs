namespace Week3_Task.Models
{
    public class Transaction
    {
        private string note;
        private string typeOfTransaction;
        private string customerName;
        private string customerAccount;
        private string transactionAmount;

        public Transaction(string note, string typeOfTransaction, string customerName, string customerAccount, string transactionAmount)
        {
            Note = note;
            TypeOfTransaction = typeOfTransaction;
            CustomerName = customerName;
            CustomerAccount = customerAccount;
            TransactionAmount = transactionAmount;
        }

        public string Note
        {
            get { return note; }
            set { this.note = value; }
        }
        
        public string TypeOfTransaction
        {
            get { return typeOfTransaction; }
            set { this.typeOfTransaction = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { this.customerName = value; }
        }
        
        public string CustomerAccount
        {
            get { return customerAccount; }
            set { this.customerAccount = value; }
        }
        
        public string TransactionAmount
        {
            get { return transactionAmount; }
            set { this.transactionAmount = value; }
        }
    }
}