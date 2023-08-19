
namespace BankWinform.UI.Forms.UserControls
{
    partial class UC_Statement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.transaction_listview = new System.Windows.Forms.ListView();
            this.customer_name = new System.Windows.Forms.ColumnHeader();
            this.account_number = new System.Windows.Forms.ColumnHeader();
            this.transaction = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.note = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 576);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 576);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(779, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 576);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(772, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 576);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(184, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 576);
            this.panel6.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(191, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 7);
            this.panel2.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(191, 569);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(581, 7);
            this.panel7.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(191, 451);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(581, 118);
            this.panel8.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(191, 444);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(581, 7);
            this.panel9.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.Controls.Add(this.transaction_listview);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(191, 7);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(581, 437);
            this.panel10.TabIndex = 10;
            // 
            // transaction_listview
            // 
            this.transaction_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customer_name,
            this.account_number,
            this.transaction,
            this.amount,
            this.note});
            this.transaction_listview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaction_listview.GridLines = true;
            this.transaction_listview.HideSelection = false;
            this.transaction_listview.Location = new System.Drawing.Point(0, 0);
            this.transaction_listview.Name = "transaction_listview";
            this.transaction_listview.Size = new System.Drawing.Size(581, 437);
            this.transaction_listview.TabIndex = 0;
            this.transaction_listview.UseCompatibleStateImageBehavior = false;
            this.transaction_listview.View = System.Windows.Forms.View.Details;
            this.transaction_listview.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // customer_name
            // 
            this.customer_name.Text = "Customer Name";
            this.customer_name.Width = 130;
            // 
            // account_number
            // 
            this.account_number.Text = "Account NO.";
            this.account_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.account_number.Width = 120;
            // 
            // transaction
            // 
            this.transaction.Text = "Transaction";
            this.transaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.transaction.Width = 100;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 70;
            // 
            // note
            // 
            this.note.Text = "Note";
            this.note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.note.Width = 100;
            // 
            // UC_Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.Name = "UC_Statement";
            this.Size = new System.Drawing.Size(960, 576);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ListView transaction_listview;
        private System.Windows.Forms.ColumnHeader customer_name;
        private System.Windows.Forms.ColumnHeader account_number;
        private System.Windows.Forms.ColumnHeader transaction;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader note;
    }
}
