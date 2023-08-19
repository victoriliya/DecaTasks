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
        private readonly IAccountRepository bank;
        public Login(IAccountRepository accountRepository)
        {
            InitializeComponent();
            this.bank = accountRepository;
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
            if (EntryIsValid())
            {
                Account account = ValidateUser(login_email_txt.Text.ToString());
                if (account != null)
                {
                    login_password_txt.Text = "";
                    login_email_txt.Text = "";
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
            Account userAccount = AccountRepository.SearchAccountWithEmail(login_email_txt.Text.ToString());
          
            if (userAccount.AccountEmail != null)
            {
                if (LoginUtilities.Verify(login_password_txt.Text.ToString(), userAccount.AccountPassword))
                {
                    return userAccount;
                }
                else
                {
                    if (MessageBox.Show("Icorrect password ..", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        login_password_txt.Text = "";
                        login_email_txt.Text = "";
                    }
                }
                return null;
            }
            else
            {
                if (MessageBox.Show("Email does not exist!!", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    login_password_txt.Text = "";
                    login_email_txt.Text = "";
                }
                return null;
            }
        }

        private bool EntryIsValid()
        {
            bool validMail = Utilities.IsValidEmail(login_email_txt.Text.ToString());
            bool validPassword = login_password_txt.Text.ToString() != String.Empty;
            if (validMail && validPassword)
            {          
                return true;
            }
            else
            {
                if (MessageBox.Show("Please fill all fields with valid inputs", "Please fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    login_password_txt.Text = "";
                    login_email_txt.Text = "";
                }
                return false;
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
