namespace ThePlatformPlatformerGame
{
    partial class ThirdLevel
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbCoin = new System.Windows.Forms.PictureBox();
            this.pbKey = new System.Windows.Forms.PictureBox();
            this.pbDoorClosed = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPlatform4 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoorClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbCoin
            // 
            this.pbCoin.BackColor = System.Drawing.Color.Transparent;
            this.pbCoin.Image = global::ThePlatformPlatformerGame.Properties.Resources.coin;
            this.pbCoin.Location = new System.Drawing.Point(1649, 42);
            this.pbCoin.Name = "pbCoin";
            this.pbCoin.Size = new System.Drawing.Size(77, 58);
            this.pbCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin.TabIndex = 18;
            this.pbCoin.TabStop = false;
            this.pbCoin.Tag = "key";
            // 
            // pbKey
            // 
            this.pbKey.Image = global::ThePlatformPlatformerGame.Properties.Resources.key;
            this.pbKey.Location = new System.Drawing.Point(1064, 232);
            this.pbKey.Name = "pbKey";
            this.pbKey.Size = new System.Drawing.Size(89, 45);
            this.pbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKey.TabIndex = 18;
            this.pbKey.TabStop = false;
            this.pbKey.Tag = "key";
            // 
            // pbDoorClosed
            // 
            this.pbDoorClosed.Image = global::ThePlatformPlatformerGame.Properties.Resources.door_closed;
            this.pbDoorClosed.Location = new System.Drawing.Point(109, 12);
            this.pbDoorClosed.Name = "pbDoorClosed";
            this.pbDoorClosed.Size = new System.Drawing.Size(60, 87);
            this.pbDoorClosed.TabIndex = 17;
            this.pbDoorClosed.TabStop = false;
            this.pbDoorClosed.Tag = "door";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::ThePlatformPlatformerGame.Properties.Resources.player;
            this.pbPlayer.Location = new System.Drawing.Point(419, 321);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(63, 75);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 16;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Tag = "player";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pictureBox5.Location = new System.Drawing.Point(1605, 106);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(169, 50);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pictureBox4.Location = new System.Drawing.Point(1605, 293);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(169, 50);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pictureBox3.Location = new System.Drawing.Point(1238, 408);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pictureBox2.Location = new System.Drawing.Point(1022, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pictureBox7.Location = new System.Drawing.Point(174, 235);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(169, 50);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pictureBox6.Location = new System.Drawing.Point(0, 97);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(169, 50);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pictureBox1.Location = new System.Drawing.Point(693, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pbPlatform4
            // 
            this.pbPlatform4.BackgroundImage = global::ThePlatformPlatformerGame.Properties.Resources.Ice_23_16x16;
            this.pbPlatform4.Location = new System.Drawing.Point(360, 408);
            this.pbPlatform4.Name = "pbPlatform4";
            this.pbPlatform4.Size = new System.Drawing.Size(193, 50);
            this.pbPlatform4.TabIndex = 2;
            this.pbPlatform4.TabStop = false;
            this.pbPlatform4.Tag = "platform";
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::ThePlatformPlatformerGame.Properties.Resources.background;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(2000, 480);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBackground.TabIndex = 1;
            this.pbBackground.TabStop = false;
            // 
            // ThirdLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 451);
            this.Controls.Add(this.pbCoin);
            this.Controls.Add(this.pbKey);
            this.Controls.Add(this.pbDoorClosed);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPlatform4);
            this.Controls.Add(this.pbBackground);
            this.Name = "ThirdLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ThirdLevel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UP);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoorClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbPlatform4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbDoorClosed;
        private System.Windows.Forms.PictureBox pbKey;
        private System.Windows.Forms.PictureBox pbCoin;
        private System.Windows.Forms.Timer timer;
    }
}