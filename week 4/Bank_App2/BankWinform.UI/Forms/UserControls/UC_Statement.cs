using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace BankWinform.UI.Forms.UserControls
{
    public partial class UC_Statement : UserControl
    {
        private List<Transaction> myTransaction;
        private List<Week3_Task.Commons.Transaction> trans = new List<Week3_Task.Commons.Transaction>() { };

        public UC_Statement(List<Week3_Task.Commons.Transaction> transaction)
        {
            InitializeComponent();
            trans = transaction;
            populateTransaction();
        }

     

        public void populateTransaction() {

            foreach (var tra in trans)
            {    
                transaction_listview.Items.Add(new ListViewItem(new string[] {tra.CustomerName, tra.CustomerAccount, tra.TypeOfTransaction, tra.TransactionAmount, tra.Note}));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
