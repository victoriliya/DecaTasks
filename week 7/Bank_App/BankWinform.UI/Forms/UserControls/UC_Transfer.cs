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
    public partial class UC_Transfer : UserControl
    {
        public static Account accountP;
        public UC_Transfer(Account account)
        {
            InitializeComponent();
            accountP = account;
        }

        private void deposit_send_btn_Click(object sender, EventArgs e)
        {
            if (CheckField())
            {

                Transfer trans = new Transfer();
                trans.AccountName = transfer_account_name_txt.Text.ToString();
                trans.SendersAccount = accountP.AccountNumber;
                trans.Amount = Double.Parse(transfer_amount_txt.Text.ToString());
                trans.RecipientsAccount = transfer_account_number_txt.Text.ToString();
                trans.Note = transfer_note_txt.Text.ToString();

                var bal = BankOperations.GetAccount(accountP);

                if (bal.Balance >= trans.Amount)
                {
                   
                    if (trans.Amount > 0)
                    {
                        if (BankOperations.Transfer(trans, accountP))
                        {
                            if (MessageBox.Show("Transfer success ..", "Please fill all fields", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                transfer_account_name_txt.Text = "";
                                transfer_account_number_txt.Text = "";
                                transfer_amount_txt.Text = "";
                                transfer_note_txt.Text = "";
                                return;
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Account Not Found ..", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                transfer_account_name_txt.Text = "";
                                transfer_account_number_txt.Text = "";
                                transfer_amount_txt.Text = "";
                                transfer_note_txt.Text = "";
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Cannot send negative value ", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            transfer_account_name_txt.Text = "";
                            transfer_account_number_txt.Text = "";
                            transfer_amount_txt.Text = "";
                            transfer_note_txt.Text = "";
                            return;
                        }
                    }

                }
                else
                {
                    if (MessageBox.Show("Insuffucient Funds..", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        transfer_account_name_txt.Text = "";
                        transfer_account_number_txt.Text = "";
                        transfer_amount_txt.Text = "";
                        transfer_note_txt.Text = "";
                        return;
                    }
                }
            }

           

           


        }


        public bool CheckField() {
            bool nameIsValid = Utilities.ValidateText(transfer_account_name_txt.Text);
            bool validAccountNumber = Utilities.ValidateNumber(transfer_account_number_txt.Text);
            bool validAmount = Utilities.ValidateNumber(transfer_amount_txt.Text);
            bool transfer = Utilities.ValidateText(transfer_note_txt.Text);
            if (nameIsValid || validAccountNumber || validAmount || transfer)
            {
                return true;
            }
            else {
                MessageBox.Show("Please fill all fields with valid details", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
