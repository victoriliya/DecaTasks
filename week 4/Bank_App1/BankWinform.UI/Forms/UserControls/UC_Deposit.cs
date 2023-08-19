using Bank.Models;
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
    public partial class UC_Deposit : UserControl
    {
        public UC_Deposit()
        {
            InitializeComponent();
        }

        private void UC_Deposit_Load(object sender, EventArgs e)
        {

        }

        private void deposit_send_btn_Click(object sender, EventArgs e)
        {

            if (MakeDeposit() != null)
            {
                MessageBox.Show("Deposit Successfull!!", "Please fill all fields", MessageBoxButtons.OK);

            }
            else{
                MessageBox.Show("Account not found!!", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Account MakeDeposit()
        {
            
            Deposit deposit = new Deposit();
            deposit.AccountName = deposit_accname_txt.Text;
            deposit.AccountNumber = deposit_account_txt.Text;
            deposit.Amount = double.Parse(deposit_amount_txt.Text);
            deposit.Note = deposit_note_txt.Text;

            Account account = BankOperations.Deposit(deposit);

            if (account != null)
            {
                return account;
            }

            return null;
            
        }


    }
}
 