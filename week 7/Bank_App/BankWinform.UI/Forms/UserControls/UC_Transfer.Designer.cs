
namespace BankWinform.UI.Forms.UserControls
{
    partial class UC_Transfer
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transfer_note_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transfer_account_number_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transfer_send_btn = new System.Windows.Forms.Button();
            this.transfer_amount_txt = new System.Windows.Forms.TextBox();
            this.transfer_account_name_txt = new System.Windows.Forms.TextBox();
            this.transfer_amt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(115, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 40);
            this.panel3.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 576);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(840, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 21;
            // 
            // transfer_note_txt
            // 
            this.transfer_note_txt.Location = new System.Drawing.Point(115, 361);
            this.transfer_note_txt.Multiline = true;
            this.transfer_note_txt.Name = "transfer_note_txt";
            this.transfer_note_txt.Size = new System.Drawing.Size(384, 48);
            this.transfer_note_txt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Note";
            // 
            // transfer_account_number_txt
            // 
            this.transfer_account_number_txt.Location = new System.Drawing.Point(115, 76);
            this.transfer_account_number_txt.Multiline = true;
            this.transfer_account_number_txt.Name = "transfer_account_number_txt";
            this.transfer_account_number_txt.Size = new System.Drawing.Size(384, 46);
            this.transfer_account_number_txt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Account Number";
            // 
            // transfer_send_btn
            // 
            this.transfer_send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.transfer_send_btn.FlatAppearance.BorderSize = 0;
            this.transfer_send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfer_send_btn.ForeColor = System.Drawing.Color.White;
            this.transfer_send_btn.Location = new System.Drawing.Point(115, 444);
            this.transfer_send_btn.Name = "transfer_send_btn";
            this.transfer_send_btn.Size = new System.Drawing.Size(384, 52);
            this.transfer_send_btn.TabIndex = 16;
            this.transfer_send_btn.Text = "Confirm";
            this.transfer_send_btn.UseVisualStyleBackColor = false;
            this.transfer_send_btn.Click += new System.EventHandler(this.deposit_send_btn_Click);
            // 
            // transfer_amount_txt
            // 
            this.transfer_amount_txt.Location = new System.Drawing.Point(115, 267);
            this.transfer_amount_txt.Multiline = true;
            this.transfer_amount_txt.Name = "transfer_amount_txt";
            this.transfer_amount_txt.Size = new System.Drawing.Size(384, 48);
            this.transfer_amount_txt.TabIndex = 15;
            // 
            // transfer_account_name_txt
            // 
            this.transfer_account_name_txt.Location = new System.Drawing.Point(115, 175);
            this.transfer_account_name_txt.Multiline = true;
            this.transfer_account_name_txt.Name = "transfer_account_name_txt";
            this.transfer_account_name_txt.Size = new System.Drawing.Size(384, 46);
            this.transfer_account_name_txt.TabIndex = 14;
            // 
            // transfer_amt
            // 
            this.transfer_amt.AutoSize = true;
            this.transfer_amt.Location = new System.Drawing.Point(115, 234);
            this.transfer_amt.Name = "transfer_amt";
            this.transfer_amt.Size = new System.Drawing.Size(108, 30);
            this.transfer_amt.TabIndex = 13;
            this.transfer_amt.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Account Name";
            // 
            // UC_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transfer_note_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transfer_account_number_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transfer_send_btn);
            this.Controls.Add(this.transfer_amount_txt);
            this.Controls.Add(this.transfer_account_name_txt);
            this.Controls.Add(this.transfer_amt);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.Name = "UC_Transfer";
            this.Size = new System.Drawing.Size(960, 576);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox transfer_note_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transfer_account_number_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button transfer_send_btn;
        private System.Windows.Forms.TextBox transfer_amount_txt;
        private System.Windows.Forms.TextBox transfer_account_name_txt;
        private System.Windows.Forms.Label transfer_amt;
        private System.Windows.Forms.Label label1;
    }
}
