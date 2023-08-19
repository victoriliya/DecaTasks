using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Week3_Task.Commons;
using Week3_Task.Core;

namespace BankWinform.UI.Forms
{
    public partial class BankSignup : Form
    {
        public BankSignup()
        {
            InitializeComponent();
        }

        private void signup_close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (EntryIsValid())
            {
                Account account = UserCreated();
                if (account != null)
                {
                    using (BankDashboard dashborad = new BankDashboard(account))
                    {
                        this.Hide();
                        dashborad.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
       
                    if (MessageBox.Show(@$"The entered email has already been registered to a {savings_radio.Text.ToLower()} account", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        signup_email_txt.Text = "";
                        signup_password_txt.Text = "";
                        c_signup_password_txt.Text = "";
                        firstname_txt.Text = "";
                        secondname_txt.Text = "";
                        savings_radio.Checked = false;
                        current_radio.Checked = false;
                    }

                }
            }
            

        }

        private Account UserCreated()
        {
            Customer customer = new Customer();
            string accType = "";
            bool isChecked = savings_radio.Checked;
            if (isChecked)
                accType = savings_radio.Text.ToLower();
            else
                accType = current_radio.Text.ToLower();

            customer.Firstname = firstname_txt.Text.ToString();
            customer.Surname = secondname_txt.Text.ToString();
            customer.Email = signup_email_txt.Text.ToString(); ;
            customer.Password = signup_password_txt.Text.ToString();
            customer.AccountType = accType;
            Account account = BankOperations.WinCreateUser(customer);
            if (account != null)
            {
                return account;
            }
            return null;        
        }

        private bool EntryIsValid()
        {
            if (Utilities.IsValidEmail(signup_email_txt.Text.ToString()) && signup_password_txt.Text.ToString() != String.Empty && c_signup_password_txt.Text.ToString() != String.Empty && Utilities.ValidateText(firstname_txt.Text.ToString()) && Utilities.ValidateText(secondname_txt.Text.ToString()))
            {
                return true;
            }
            else
            {
                if (MessageBox.Show("Please fill all fields with valid inputs", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    signup_email_txt.Text = "";
                    signup_password_txt.Text = "";
                    c_signup_password_txt.Text = "";
                    firstname_txt.Text = "";
                    secondname_txt.Text = "";
                    savings_radio.Checked = false;
                    current_radio.Checked = false;
                }               
                return false;
            }
        }
    }
}
