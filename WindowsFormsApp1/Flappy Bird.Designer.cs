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
            this.ground.Location = new System.Drawing.Point(-4, 531);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(805, 145);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PipeTop.BackgroundImage")));
            this.PipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PipeTop.Location = new System.Drawing.Point(656, -3);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(99, 115);
            this.PipeTop.TabIndex = 1;
            this.PipeTop.TabStop = false;
            this.PipeTop.Click += new System.EventHandler(this.PipeTop_Click);
            // 
            // BIRD
            // 
            this.BIRD.BackColor = System.Drawing.Color.Transparent;
            this.BIRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BIRD.Image = ((System.Drawing.Image)(resources.GetObject("BIRD.Image")));
            this.BIRD.Location = new System.Drawing.Point(90, 160);
            this.BIRD.Name = "BIRD";
            this.BIRD.Size = new System.Drawing.Size(62, 51);
            this.BIRD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BIRD.TabIndex = 2;
            this.BIRD.TabStop = false;
            this.BIRD.Click += new System.EventHandler(this.BIRD_Click);
            // 
            // pipebottom
            // 
            this.pipebottom.BackColor = System.Drawing.Color.Transparent;
            this.pipebottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipebottom.BackgroundImage")));
            this.pipebottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipebottom.Location = new System.Drawing.Point(543, 416);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(97, 118);
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
            // Flappy_Bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 646);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.BIRD);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.ground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
    }
}