namespace WindowsFormsApp1
{
    partial class Flappy_Bird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappy_Bird));
            this.ground = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.BIRD = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BIRD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Location = new System.Drawing.Point(-2, 521);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(809, 145);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PipeTop.BackgroundImage")));
            this.PipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PipeTop.Location = new System.Drawing.Point(669, -2);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(99, 115);
            this.PipeTop.TabIndex = 1;
            this.PipeTop.TabStop = false;
            // 
            // BIRD
            // 
            this.BIRD.BackColor = System.Drawing.Color.Transparent;
            this.BIRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BIRD.Image = ((System.Drawing.Image)(resources.GetObject("BIRD.Image")));
            this.BIRD.Location = new System.Drawing.Point(135, 171);
            this.BIRD.Name = "BIRD";
            this.BIRD.Size = new System.Drawing.Size(102, 85);
            this.BIRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BIRD.TabIndex = 2;
            this.BIRD.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.BackColor = System.Drawing.Color.Transparent;
            this.pipebottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipebottom.BackgroundImage")));
            this.pipebottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipebottom.Location = new System.Drawing.Point(430, 392);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(97, 131);
            this.pipebottom.TabIndex = 3;
            this.pipebottom.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.Transparent;
            this.scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(45, 28);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(107, 36);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(353, 282);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 49);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Flappy_Bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.BIRD);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.ground);
            this.Name = "Flappy_Bird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy_Bird";
            this.Load += new System.EventHandler(this.Flappy_Bird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BIRD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox BIRD;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_exit;
    }
}