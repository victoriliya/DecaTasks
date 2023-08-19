
namespace BankWinform.UI.Forms.UserControls
{
    partial class UC_Deposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deposit_account_txt = new System.Windows.Forms.TextBox();
            this.deposit_accname_txt = new System.Windows.Forms.TextBox();
            this.deposit_send_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deposit_amount_txt = new System.Windows.Forms.TextBox();
            this.deposit_note_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Name";
            // 
            // deposit_account_txt
            // 
            this.deposit_account_txt.Location = new System.Drawing.Point(122, 183);
            this.deposit_account_txt.Multiline = true;
            this.deposit_account_txt.Name = "deposit_account_txt";
            this.deposit_account_txt.Size = new System.Drawing.Size(384, 46);
            this.deposit_account_txt.TabIndex = 2;
            // 
            // deposit_accname_txt
            // 
            this.deposit_accname_txt.Location = new System.Drawing.Point(122, 275);
            this.deposit_accname_txt.Multiline = true;
            this.deposit_accname_txt.Name = "deposit_accname_txt";
            this.deposit_accname_txt.Size = new System.Drawing.Size(384, 48);
            this.deposit_accname_txt.TabIndex = 3;
            // 
            // deposit_send_btn
            // 
            this.deposit_send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.deposit_send_btn.FlatAppearance.BorderSize = 0;
            this.deposit_send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit_send_btn.ForeColor = System.Drawing.Color.White;
            this.deposit_send_btn.Location = new System.Drawing.Point(122, 452);
            this.deposit_send_btn.Name = "deposit_send_btn";
            this.deposit_send_btn.Size = new System.Drawing.Size(384, 52);
            this.deposit_send_btn.TabIndex = 4;
            this.deposit_send_btn.Text = "Send";
            this.deposit_send_btn.UseVisualStyleBackColor = false;
            this.deposit_send_btn.Click += new System.EventHandler(this.deposit_send_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // deposit_amount_txt
            // 
            this.deposit_amount_txt.Location = new System.Drawing.Point(122, 84);
            this.deposit_amount_txt.Multiline = true;
            this.deposit_amount_txt.Name = "deposit_amount_txt";
            this.deposit_amount_txt.Size = new System.Drawing.Size(384, 46);
            this.deposit_amount_txt.TabIndex = 6;
            // 
            // deposit_note_txt
            // 
            this.deposit_note_txt.Location = new System.Drawing.Point(122, 369);
            this.deposit_note_txt.Multiline = true;
            this.deposit_note_txt.Name = "deposit_note_txt";
            this.deposit_note_txt.Size = new System.Drawing.Size(384, 48);
            this.deposit_note_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note";
            // 
            // UC_Deposit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deposit_note_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deposit_amount_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deposit_send_btn);
            this.Controls.Add(this.deposit_accname_txt);
            this.Controls.Add(this.deposit_account_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.Name = "UC_Deposit";
            this.Size = new System.Drawing.Size(960, 576);
            this.Load += new System.EventHandler(this.UC_Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deposit_account_txt;
        private System.Windows.Forms.TextBox deposit_accname_txt;
        private System.Windows.Forms.Button deposit_send_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deposit_amount_txt;
        private System.Windows.Forms.TextBox deposit_note_txt;
        private System.Windows.Forms.Label label4;
    }
}
