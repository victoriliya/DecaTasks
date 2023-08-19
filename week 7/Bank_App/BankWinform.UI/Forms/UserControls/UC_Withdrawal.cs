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
    public partial class UC_Withdrawal : UserControl
    {
        private Account accountP;
        public UC_Withdrawal(Account account)
        {
            accountP = account;
            InitializeComponent();
        }

        private void withdraw_send_btn_Click(object sender, EventArgs e)
        {
            

            if (CheckFields())
            {
                Withdraw withdraw = new Withdraw();
                withdraw.Amount = double.Parse(withdrawal_amount_txt.Text);
                withdraw.Note = withdrawal_note_txt.Text.ToString();
                var bal = BankOperations.GetAccount(accountP);
                if (bal.Balance > withdraw.Amount)
                {
                    if (withdraw.Amount  > 0)
                    {
                        if (BankOperations.Withdraw(withdraw, accountP))
                        {
                            if (MessageBox.Show("Withdraw success..", "Please fill all fields", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                withdrawal_amount_txt.Text = "";
                                withdrawal_note_txt.Text = "";
                                return;
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Error in withdrawal ..", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                withdrawal_amount_txt.Text = "";
                                withdrawal_note_txt.Text = "";
                                return;
                            }
                        }
                    }else
                    {
                        if (MessageBox.Show("Cannot withdraw zero or negative value..", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            withdrawal_amount_txt.Text = "";
                            withdrawal_note_txt.Text = "";
                            return;
                        }
                    }

                }
                else
                {
                    if (MessageBox.Show("Insufficient funds ..", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        withdrawal_amount_txt.Text = "";
                        withdrawal_note_txt.Text = "";
                        return;
                    }
                }
            }

        }


        public bool CheckFields()
        {
            if (Utilities.ValidateNumber(withdrawal_amount_txt.Text) && Utilities.ValidateText(withdrawal_note_text.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please fill all fields with valid inputs", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                withdrawal_amount_txt.Text = "";
                withdrawal_note_txt.Text = "";
                return false;
            }
        }

        private void withdrawal_note_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Withdrawal_Load(object sender, EventArgs e)
        {

        }
    }
}
