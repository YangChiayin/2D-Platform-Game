namespace ChiayinYang_Assignment2
{
    partial class PlatformGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatformGame));
            player = new PictureBox();
            coin1 = new PictureBox();
            platform1 = new PictureBox();
            platform2 = new PictureBox();
            coin2 = new PictureBox();
            enemy3 = new PictureBox();
            coin3 = new PictureBox();
            coin4 = new PictureBox();
            goal = new PictureBox();
            enemy2 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            labelScoreAndTime = new Label();
            enemy1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)platform1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)platform2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Image = Properties.Resources._129689af6922014;
            player.Location = new Point(13, 950);
            player.Name = "player";
            player.Size = new Size(90, 107);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // coin1
            // 
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(319, 723);
            coin1.Name = "coin1";
            coin1.Size = new Size(65, 82);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 0;
            coin1.TabStop = false;
            // 
            // platform1
            // 
            platform1.Image = (Image)resources.GetObject("platform1.Image");
            platform1.Location = new Point(195, 864);
            platform1.Name = "platform1";
            platform1.Size = new Size(330, 65);
            platform1.SizeMode = PictureBoxSizeMode.StretchImage;
            platform1.TabIndex = 0;
            platform1.TabStop = false;
            // 
            // platform2
            // 
            platform2.Image = (Image)resources.GetObject("platform2.Image");
            platform2.Location = new Point(587, 675);
            platform2.Name = "platform2";
            platform2.Size = new Size(511, 71);
            platform2.SizeMode = PictureBoxSizeMode.StretchImage;
            platform2.TabIndex = 0;
            platform2.TabStop = false;
            // 
            // coin2
            // 
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(797, 427);
            coin2.Name = "coin2";
            coin2.Size = new Size(65, 82);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 0;
            coin2.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(581, 891);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(84, 166);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 0;
            enemy3.TabStop = false;
            // 
            // coin3
            // 
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(736, 864);
            coin3.Name = "coin3";
            coin3.Size = new Size(65, 82);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 0;
            coin3.TabStop = false;
            // 
            // coin4
            // 
            coin4.Image = (Image)resources.GetObject("coin4.Image");
            coin4.Location = new Point(1247, 864);
            coin4.Name = "coin4";
            coin4.Size = new Size(65, 82);
            coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            coin4.TabIndex = 0;
            coin4.TabStop = false;
            // 
            // goal
            // 
            goal.Image = (Image)resources.GetObject("goal.Image");
            goal.Location = new Point(1559, 813);
            goal.Name = "goal";
            goal.Size = new Size(263, 244);
            goal.SizeMode = PictureBoxSizeMode.StretchImage;
            goal.TabIndex = 0;
            goal.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(671, 948);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(79, 109);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 1;
            enemy2.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // labelScoreAndTime
            // 
            labelScoreAndTime.AutoSize = true;
            labelScoreAndTime.Location = new Point(1586, 77);
            labelScoreAndTime.Name = "labelScoreAndTime";
            labelScoreAndTime.Size = new Size(0, 32);
            labelScoreAndTime.TabIndex = 2;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(587, 566);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(79, 113);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 1;
            enemy1.TabStop = false;
            // 
            // PlatformGame
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1834, 1059);
            Controls.Add(player);
            Controls.Add(labelScoreAndTime);
            Controls.Add(platform2);
            Controls.Add(platform1);
            Controls.Add(coin4);
            Controls.Add(coin3);
            Controls.Add(coin2);
            Controls.Add(coin1);
            Controls.Add(goal);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Name = "PlatformGame";
            Text = "Form1";
            KeyDown += PlatformGame_KeyDown;
            KeyUp += PlatformGame_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)platform1).EndInit();
            ((System.ComponentModel.ISupportInitialize)platform2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)goal).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox coin1;
        private PictureBox platform1;
        private PictureBox platform2;
        private PictureBox coin2;
        private PictureBox enemy3;
        private PictureBox coin3;
        private PictureBox coin4;
        private PictureBox goal;
        private PictureBox enemy2;
        private System.Windows.Forms.Timer timer;
        private Label labelScoreAndTime;
        private PictureBox enemy1;
    }
}
