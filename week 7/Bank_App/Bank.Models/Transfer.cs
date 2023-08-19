using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Models
{

    /// <summary>
    /// Sets transfer data
    /// </summary>
    public class Transfer
    {
        /*Fields*/
        public string RecipientsAccount { get; set; }
        public string SendersAccount { get; set; }
        public double Amount { get; set; }
        public string AccountName { get; set; }
        public string Note { get; set; }
    }
}
