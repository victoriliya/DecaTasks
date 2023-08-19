
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
            this.deposit_send_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deposit_amount_txt = new System.Windows.Forms.TextBox();
            this.deposit_note_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // deposit_send_btn
            // 
            this.deposit_send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.deposit_send_btn.FlatAppearance.BorderSize = 0;
            this.deposit_send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit_send_btn.ForeColor = System.Drawing.Color.White;
            this.deposit_send_btn.Location = new System.Drawing.Point(115, 261);
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
            this.label3.Location = new System.Drawing.Point(115, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // deposit_amount_txt
            // 
            this.deposit_amount_txt.Location = new System.Drawing.Point(115, 76);
            this.deposit_amount_txt.Multiline = true;
            this.deposit_amount_txt.Name = "deposit_amount_txt";
            this.deposit_amount_txt.Size = new System.Drawing.Size(384, 46);
            this.deposit_amount_txt.TabIndex = 6;
            // 
            // deposit_note_txt
            // 
            this.deposit_note_txt.Location = new System.Drawing.Point(115, 178);
            this.deposit_note_txt.Multiline = true;
            this.deposit_note_txt.Name = "deposit_note_txt";
            this.deposit_note_txt.Size = new System.Drawing.Size(384, 48);
            this.deposit_note_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(840, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 576);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(115, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 40);
            this.panel3.TabIndex = 11;
            // 
            // UC_Deposit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deposit_note_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deposit_amount_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deposit_send_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(181)))), ((int)(((byte)(40)))));
            this.Name = "UC_Deposit";
            this.Size = new System.Drawing.Size(960, 576);
            this.Load += new System.EventHandler(this.UC_Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deposit_send_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deposit_amount_txt;
        private System.Windows.Forms.TextBox deposit_note_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
