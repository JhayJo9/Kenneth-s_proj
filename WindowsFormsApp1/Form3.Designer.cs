namespace WindowsFormsApp1
{
    partial class Guessing_game
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Enter_number = new System.Windows.Forms.TextBox();
            this.lbl_guessed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit_gg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number between 1 and 100";
            // 
            // txt_Enter_number
            // 
            this.txt_Enter_number.Location = new System.Drawing.Point(91, 68);
            this.txt_Enter_number.Name = "txt_Enter_number";
            this.txt_Enter_number.Size = new System.Drawing.Size(100, 20);
            this.txt_Enter_number.TabIndex = 1;
            this.txt_Enter_number.TextChanged += new System.EventHandler(this.txt_Enter_number_TextChanged);
            // 
            // lbl_guessed
            // 
            this.lbl_guessed.AutoSize = true;
            this.lbl_guessed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_guessed.Location = new System.Drawing.Point(88, 107);
            this.lbl_guessed.Name = "lbl_guessed";
            this.lbl_guessed.Size = new System.Drawing.Size(0, 13);
            this.lbl_guessed.TabIndex = 2;
            this.lbl_guessed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit_gg
            // 
            this.btn_exit_gg.Location = new System.Drawing.Point(105, 198);
            this.btn_exit_gg.Name = "btn_exit_gg";
            this.btn_exit_gg.Size = new System.Drawing.Size(75, 23);
            this.btn_exit_gg.TabIndex = 4;
            this.btn_exit_gg.Text = "Exit";
            this.btn_exit_gg.UseVisualStyleBackColor = true;
            this.btn_exit_gg.Click += new System.EventHandler(this.btn_exit_gg_Click);
            // 
            // Guessing_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_exit_gg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_guessed);
            this.Controls.Add(this.txt_Enter_number);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Guessing_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.Guessing_game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Enter_number;
        private System.Windows.Forms.Label lbl_guessed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_exit_gg;
    }
}