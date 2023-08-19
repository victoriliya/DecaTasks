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
        private Account faccount;
        public UC_Deposit(Account account)
        {
            InitializeComponent();
            this.faccount = account;
        }

        private void UC_Deposit_Load(object sender, EventArgs e)
        {

        }

        private void deposit_send_btn_Click(object sender, EventArgs e)
        {
            if (CheckField())
            {
                double s = Double.Parse(deposit_amount_txt.Text.ToString());
                if (s > 0)
                {
                    if (MakeDeposit() != null)
                    {
                        if (MessageBox.Show("Deposit Successfull!!", "Pleasefill all fields", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            deposit_note_txt.Text = "";
                            deposit_amount_txt.Text = "";
                            return;
                        }

                    }
                }
                else {                
                    if (MessageBox.Show("Cannot accept negative or zero value", "Please fill all fields", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        deposit_note_txt.Text = "";
                        deposit_amount_txt.Text = "";
                        return;
                    }
                }
                
            }


        }

        public bool CheckField()
        {
            if (Utilities.ValidateNumber(deposit_amount_txt.Text) && Utilities.ValidateText(deposit_note_txt.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please fill all fields with valid entry", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deposit_note_txt.Text = "";
                deposit_amount_txt.Text = "";
                return false;
            }
        }

        private Account MakeDeposit()
        {
            
            Deposit deposit = new Deposit();
            deposit.AccountName = faccount.AccountName;
            deposit.AccountNumber = faccount.AccountNumber;
            deposit.Amount = double.Parse(deposit_amount_txt.Text);
            deposit.Note = deposit_note_txt.Text;

            Account account = BankOperations.Deposit(deposit, faccount);

            if (account != null)
            {
                return account;
            }

            return null;
            
        }


    }
}
 