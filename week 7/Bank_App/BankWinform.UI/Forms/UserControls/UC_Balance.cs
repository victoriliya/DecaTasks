using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Week3_Task.Commons;
using Week3_Task.Core;

namespace BankWinform.UI.Forms.UserControls
{
    public partial class UC_Balance : UserControl
    {
        private Account account;
        public UC_Balance(Account account)
        {
            InitializeComponent();
            this.account = account;
            balance_text.Text =  Math.Round(GetBalance(), 2).ToString("0.00");
        }

        public double GetBalance() {
            return BankOperations.GetAccount(account).Balance;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
