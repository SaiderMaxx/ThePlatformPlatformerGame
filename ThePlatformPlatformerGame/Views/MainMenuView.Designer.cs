namespace ThePlatformPlatformerGame
{
    partial class MainMenu
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPlatformer = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(304, 253);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(146, 64);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblPlatformer
            // 
            this.lblPlatformer.AutoSize = true;
            this.lblPlatformer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlatformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.8F, System.Drawing.FontStyle.Bold);
            this.lblPlatformer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlatformer.Location = new System.Drawing.Point(172, 76);
            this.lblPlatformer.Name = "lblPlatformer";
            this.lblPlatformer.Size = new System.Drawing.Size(316, 69);
            this.lblPlatformer.TabIndex = 1;
            this.lblPlatformer.Text = "Platformer";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Transparent;
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold);
            this.lblGame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGame.Location = new System.Drawing.Point(415, 130);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(134, 31);
            this.lblGame.TabIndex = 2;
            this.lblGame.Text = "the game";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.background_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.lblPlatformer);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblPlatformer;
        private System.Windows.Forms.Label lblGame;
    }
}

