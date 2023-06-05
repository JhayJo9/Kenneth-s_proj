namespace WindowsFormsApp1
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.Guessing_game = new System.Windows.Forms.Button();
            this.Bricks_breaker = new System.Windows.Forms.Button();
            this.Space_invader = new System.Windows.Forms.Button();
            this.Flappy_bird = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compilation of C# Games in ITEC21";
            // 
            // Guessing_game
            // 
            this.Guessing_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guessing_game.Location = new System.Drawing.Point(57, 67);
            this.Guessing_game.Margin = new System.Windows.Forms.Padding(4);
            this.Guessing_game.Name = "Guessing_game";
            this.Guessing_game.Size = new System.Drawing.Size(123, 30);
            this.Guessing_game.TabIndex = 2;
            this.Guessing_game.Text = "Guessing Game";
            this.Guessing_game.UseVisualStyleBackColor = true;
            this.Guessing_game.Click += new System.EventHandler(this.Guessing_game_Click);
            // 
            // Bricks_breaker
            // 
            this.Bricks_breaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bricks_breaker.Location = new System.Drawing.Point(211, 67);
            this.Bricks_breaker.Margin = new System.Windows.Forms.Padding(4);
            this.Bricks_breaker.Name = "Bricks_breaker";
            this.Bricks_breaker.Size = new System.Drawing.Size(123, 30);
            this.Bricks_breaker.TabIndex = 3;
            this.Bricks_breaker.Text = "Bricks Breaker";
            this.Bricks_breaker.UseVisualStyleBackColor = true;
            this.Bricks_breaker.Click += new System.EventHandler(this.Bricks_breaker_Click);
            // 
            // Space_invader
            // 
            this.Space_invader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Space_invader.Location = new System.Drawing.Point(57, 126);
            this.Space_invader.Margin = new System.Windows.Forms.Padding(4);
            this.Space_invader.Name = "Space_invader";
            this.Space_invader.Size = new System.Drawing.Size(123, 30);
            this.Space_invader.TabIndex = 4;
            this.Space_invader.Text = "Space Invader";
            this.Space_invader.UseVisualStyleBackColor = true;
            // 
            // Flappy_bird
            // 
            this.Flappy_bird.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flappy_bird.Location = new System.Drawing.Point(211, 126);
            this.Flappy_bird.Margin = new System.Windows.Forms.Padding(4);
            this.Flappy_bird.Name = "Flappy_bird";
            this.Flappy_bird.Size = new System.Drawing.Size(123, 30);
            this.Flappy_bird.TabIndex = 5;
            this.Flappy_bird.Text = "Flappy Bird";
            this.Flappy_bird.UseVisualStyleBackColor = true;
            this.Flappy_bird.Click += new System.EventHandler(this.Flappy_bird_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(80, 189);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "Credits";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(211, 189);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 321);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Flappy_bird);
            this.Controls.Add(this.Space_invader);
            this.Controls.Add(this.Bricks_breaker);
            this.Controls.Add(this.Guessing_game);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guessing_game;
        private System.Windows.Forms.Button Bricks_breaker;
        private System.Windows.Forms.Button Space_invader;
        private System.Windows.Forms.Button Flappy_bird;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}