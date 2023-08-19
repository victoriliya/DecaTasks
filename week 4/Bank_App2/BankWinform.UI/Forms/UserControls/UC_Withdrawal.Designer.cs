
namespace BankWinform.UI.Forms.UserControls
{
    partial class UC_Withdrawal
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
            this.withdrawal_note_txt = new System.Windows.Forms.TextBox();
            this.withdrawal_note_text = new System.Windows.Forms.Label();
            this.withdraw_send_btn = new System.Windows.Forms.Button();
            this.withdrawal_amount_txt = new System.Windows.Forms.TextBox();
            this.withdrawal_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // withdrawal_note_txt
            // 
            this.withdrawal_note_txt.Location = new System.Drawing.Point(100, 256);
            this.withdrawal_note_txt.Multiline = true;
            this.withdrawal_note_txt.Name = "withdrawal_note_txt";
            this.withdrawal_note_txt.Size = new System.Drawing.Size(384, 48);
            this.withdrawal_note_txt.TabIndex = 13;
            // 
            // withdrawal_note_text
            // 
            this.withdrawal_note_text.AutoSize = true;
            this.withdrawal_note_text.Location = new System.Drawing.Point(100, 223);
            this.withdrawal_note_text.Name = "withdrawal_note_text";
            this.withdrawal_note_text.Size = new System.Drawing.Size(71, 30);
            this.withdrawal_note_text.TabIndex = 12;
            this.withdrawal_note_text.Text = "Note";
            // 
            // withdraw_send_btn
            // 
            this.withdraw_send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.withdraw_send_btn.FlatAppearance.BorderSize = 0;
            this.withdraw_send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw_send_btn.ForeColor = System.Drawing.Color.White;
            this.withdraw_send_btn.Location = new System.Drawing.Point(100, 339);
            this.withdraw_send_btn.Name = "withdraw_send_btn";
            this.withdraw_send_btn.Size = new System.Drawing.Size(384, 52);
            this.withdraw_send_btn.TabIndex = 11;
            this.withdraw_send_btn.Text = "Withdraw";
            this.withdraw_send_btn.UseVisualStyleBackColor = false;
            // 
            // withdrawal_amount_txt
            // 
            this.withdrawal_amount_txt.Location = new System.Drawing.Point(100, 162);
            this.withdrawal_amount_txt.Multiline = true;
            this.withdrawal_amount_txt.Name = "withdrawal_amount_txt";
            this.withdrawal_amount_txt.Size = new System.Drawing.Size(384, 48);
            this.withdrawal_amount_txt.TabIndex = 10;
            // 
            // withdrawal_text
            // 
            this.withdrawal_text.AutoSize = true;
            this.withdrawal_text.Location = new System.Drawing.Point(100, 129);
            this.withdrawal_text.Name = "withdrawal_text";
            this.withdrawal_text.Size = new System.Drawing.Size(197, 30);
            this.withdrawal_text.TabIndex = 9;
            this.withdrawal_text.Text = "Account Name";
            // 
            // UC_Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.withdrawal_note_txt);
            this.Controls.Add(this.withdrawal_note_text);
            this.Controls.Add(this.withdraw_send_btn);
            this.Controls.Add(this.withdrawal_amount_txt);
            this.Controls.Add(this.withdrawal_text);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.Name = "UC_Withdrawal";
            this.Size = new System.Drawing.Size(960, 576);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox withdrawal_note_txt;
        private System.Windows.Forms.Label withdrawal_note_text;
        private System.Windows.Forms.Button withdraw_send_btn;
        private System.Windows.Forms.TextBox withdrawal_amount_txt;
        private System.Windows.Forms.Label withdrawal_text;
    }
}
