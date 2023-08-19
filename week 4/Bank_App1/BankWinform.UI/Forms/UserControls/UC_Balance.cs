using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankWinform.UI.Forms.UserControls
{
    public partial class UC_Balance : UserControl
    {
        public UC_Balance(double balance)
        {
            InitializeComponent();
            balance_text.Text =  Math.Round(balance, 2).ToString("0.00");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
