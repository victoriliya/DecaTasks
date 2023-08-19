using Bank.Core;
using BankWinform.UI.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Week3_Task.Commons;

namespace BankWinform.UI.Forms
{
    public partial class BankDashboard : Form
    {
        private Account account;
        public BankDashboard(Account account)
        {
            this.account = account;
            InitializeComponent();
            account_name_text.Text = account.AccountName;
            acctype_text.Text = Utilities.FirstCharacterToUpper(account.AccountType);

            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);


        }

        private void AddControlsToPanel(Control c) {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void login_close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            MovePanel(home_btn);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }
        public void MovePanel(Control btn) {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePanel(deposit_btn);
            UC_Deposit ucd = new UC_Deposit();
            AddControlsToPanel(ucd);
        }

        private void withdrawal_btn_Click(object sender, EventArgs e)
        {
            MovePanel(withdrawal_btn);
            MovePanel(home_btn);
            UC_Withdrawal ucw = new UC_Withdrawal();
            AddControlsToPanel(ucw);
        }

        private void balamce_btn_Click(object sender, EventArgs e)
        {
            MovePanel(balamce_btn);
            UC_Balance ucb = new UC_Balance(account.Balance);
            AddControlsToPanel(ucb);
           

        }

        private void acc_statemen_btn_Click(object sender, EventArgs e)
        {
            var trans = myTransactions(account);
            MovePanel(acc_statemen_btn);
            UC_Statement ucs = new UC_Statement(trans);
            AddControlsToPanel(ucs);

        }
        public List<Transaction> myTransactions(Account account) {
            return TransactionRepository.WinStatementOfAccount(account);
        } 
    }
}
