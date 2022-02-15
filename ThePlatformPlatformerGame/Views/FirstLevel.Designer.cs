namespace ThePlatformPlatformerGame
{
    partial class FirstLevel
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
            this.pbDoorOpen = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbPlatform3 = new System.Windows.Forms.PictureBox();
            this.pbPlatform4 = new System.Windows.Forms.PictureBox();
            this.pbPlatform5 = new System.Windows.Forms.PictureBox();
            this.pbPlatform1 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoorOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDoorOpen
            // 
            this.pbDoorOpen.Image = global::ThePlatformPlatformerGame.Properties.Resources.door_open;
            this.pbDoorOpen.Location = new System.Drawing.Point(12, 33);
            this.pbDoorOpen.Name = "pbDoorOpen";
            this.pbDoorOpen.Size = new System.Drawing.Size(56, 87);
            this.pbDoorOpen.TabIndex = 2;
            this.pbDoorOpen.TabStop = false;
            this.pbDoorOpen.Tag = "door_open";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pictureBox2.Location = new System.Drawing.Point(603, 329);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pbPlatform3
            // 
            this.pbPlatform3.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pbPlatform3.Location = new System.Drawing.Point(359, 255);
            this.pbPlatform3.Name = "pbPlatform3";
            this.pbPlatform3.Size = new System.Drawing.Size(137, 50);
            this.pbPlatform3.TabIndex = 1;
            this.pbPlatform3.TabStop = false;
            this.pbPlatform3.Tag = "platform";
            // 
            // pbPlatform4
            // 
            this.pbPlatform4.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pbPlatform4.Location = new System.Drawing.Point(159, 195);
            this.pbPlatform4.Name = "pbPlatform4";
            this.pbPlatform4.Size = new System.Drawing.Size(137, 50);
            this.pbPlatform4.TabIndex = 1;
            this.pbPlatform4.TabStop = false;
            this.pbPlatform4.Tag = "platform";
            // 
            // pbPlatform5
            // 
            this.pbPlatform5.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pbPlatform5.Location = new System.Drawing.Point(0, 117);
            this.pbPlatform5.Name = "pbPlatform5";
            this.pbPlatform5.Size = new System.Drawing.Size(137, 50);
            this.pbPlatform5.TabIndex = 1;
            this.pbPlatform5.TabStop = false;
            this.pbPlatform5.Tag = "platform";
            // 
            // pbPlatform1
            // 
            this.pbPlatform1.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pbPlatform1.Location = new System.Drawing.Point(0, 401);
            this.pbPlatform1.Name = "pbPlatform1";
            this.pbPlatform1.Size = new System.Drawing.Size(552, 50);
            this.pbPlatform1.TabIndex = 1;
            this.pbPlatform1.TabStop = false;
            this.pbPlatform1.Tag = "platform";
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::ThePlatformPlatformerGame.Properties.Resources.background;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(2000, 480);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::ThePlatformPlatformerGame.Properties.Resources.player;
            this.pbPlayer.Location = new System.Drawing.Point(187, 291);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(63, 75);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 15;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Tag = "player";
            // 
            // FirstLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 452);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbDoorOpen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbPlatform3);
            this.Controls.Add(this.pbPlatform4);
            this.Controls.Add(this.pbPlatform5);
            this.Controls.Add(this.pbPlatform1);
            this.Controls.Add(this.pbBackground);
            this.Name = "FirstLevel";
            this.Text = "FirstLevel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Down);
            ((System.ComponentModel.ISupportInitialize)(this.pbDoorOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbPlatform1;
        private System.Windows.Forms.PictureBox pbPlatform5;
        private System.Windows.Forms.PictureBox pbPlatform4;
        private System.Windows.Forms.PictureBox pbPlatform3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbDoorOpen;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbPlayer;
    }
}