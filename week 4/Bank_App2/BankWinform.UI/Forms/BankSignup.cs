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
            Account account = UserCreated();
            if (account != null)
            {
                using (BankDashboard dashborad = new BankDashboard(account))
                {
                    //this.Hide();
                    dashborad.ShowDialog();
                    //this.Close();
                }
            }
            else {
                MessageBox.Show("Account creates", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
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
    }
}
