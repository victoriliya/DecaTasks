using Bank.Commons;
using Bank.Core;
using Bank.Data;
using BankWinform.UI.Forms;
using BankWinform.UI.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week3_Task.Commons;

namespace BankWinform.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Account account = ValidateUser(login_email_txt.Text.ToString());
            if (formIsValid())
            {
                if (account != null)
                {
                    using (BankDashboard dashborad = new BankDashboard(account)) {    
                        //this.Hide();
                        dashborad.ShowDialog();
                        //this.Close();
                    }
                }
                     
            }
        }

        private Account ValidateUser(string email)
        {
            Account userAccount = AccountRepository.SearchAccountDB(login_email_txt.Text.ToString());
            if (userAccount != null)
            {
                Console.WriteLine("Account password\n" + userAccount.AccountPassword);
                Console.WriteLine("user password\n" + login_password_txt.Text.ToString());
                Console.WriteLine(LoginUtilities.Verify(login_password_txt.Text.ToString(), userAccount.AccountPassword));
           
                if (LoginUtilities.Verify(login_password_txt.Text.ToString(), userAccount.AccountPassword))
                {
                    return userAccount;
                }
                else {
                    MessageBox.Show("Icorrect password ..", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return null;
            }
            else
            {
                MessageBox.Show("Email does not exist!!", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool formIsValid()
        {
            Console.WriteLine(login_email_txt.Text.ToString());
            Console.WriteLine(login_password_txt.Text.ToString());
            if ( login_email_txt.Text.ToString() == String.Empty || login_password_txt.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Required fields are empty", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else{
                Console.WriteLine("This is amazing!!!");
                return true;
            }
     
        }



        private void login_username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void create_account_btn_Click(object sender, EventArgs e)
        {
            using (BankSignup signup = new BankSignup())
            {
                signup.ShowDialog(); ;
            }
        }
    }
}
