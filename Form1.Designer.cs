namespace F_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panalGame = new System.Windows.Forms.Panel();
            this.labGameOver = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L8 = new System.Windows.Forms.PictureBox();
            this.L7 = new System.Windows.Forms.PictureBox();
            this.L9 = new System.Windows.Forms.PictureBox();
            this.L5 = new System.Windows.Forms.PictureBox();
            this.L4 = new System.Windows.Forms.PictureBox();
            this.L6 = new System.Windows.Forms.PictureBox();
            this.L2 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.PictureBox();
            this.L3 = new System.Windows.Forms.PictureBox();
            this.timeAction = new System.Windows.Forms.Timer(this.components);
            this.lbwait = new System.Windows.Forms.Label();
            this.timerwait = new System.Windows.Forms.Timer(this.components);
            this.lbscore = new System.Windows.Forms.Label();
            this.panalGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).BeginInit();
            this.SuspendLayout();
            // 
            // panalGame
            // 
            this.panalGame.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panalGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panalGame.Controls.Add(this.labGameOver);
            this.panalGame.Controls.Add(this.Player);
            this.panalGame.Controls.Add(this.car2);
            this.panalGame.Controls.Add(this.car1);
            this.panalGame.Controls.Add(this.car3);
            this.panalGame.Controls.Add(this.pictureBox1);
            this.panalGame.Controls.Add(this.L8);
            this.panalGame.Controls.Add(this.L7);
            this.panalGame.Controls.Add(this.L9);
            this.panalGame.Controls.Add(this.L5);
            this.panalGame.Controls.Add(this.L4);
            this.panalGame.Controls.Add(this.L6);
            this.panalGame.Controls.Add(this.L2);
            this.panalGame.Controls.Add(this.L3);
            this.panalGame.Controls.Add(this.L1);
            this.panalGame.Location = new System.Drawing.Point(13, 72);
            this.panalGame.Name = "panalGame";
            this.panalGame.Size = new System.Drawing.Size(633, 537);
            this.panalGame.TabIndex = 0;
            this.panalGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labGameOver
            // 
            this.labGameOver.AutoSize = true;
            this.labGameOver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labGameOver.Font = new System.Drawing.Font("Gabriola", 30F, System.Drawing.FontStyle.Bold);
            this.labGameOver.ForeColor = System.Drawing.Color.Firebrick;
            this.labGameOver.Location = new System.Drawing.Point(206, 222);
            this.labGameOver.Name = "labGameOver";
            this.labGameOver.Size = new System.Drawing.Size(219, 92);
            this.labGameOver.TabIndex = 14;
            this.labGameOver.Text = "Game Over";
            this.labGameOver.Visible = false;
            this.labGameOver.Click += new System.EventHandler(this.labGameOver_Click);
            // 
            // Player
            // 
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(275, 437);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(45, 99);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 10;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // car2
            // 
            this.car2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.car2.Image = global::F_Project.Properties.Resources.car4;
            this.car2.Location = new System.Drawing.Point(334, 23);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(45, 99);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 13;
            this.car2.TabStop = false;
            this.car2.Click += new System.EventHandler(this.car3_Click);
            // 
            // car1
            // 
            this.car1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.car1.Image = global::F_Project.Properties.Resources.car2;
            this.car1.Location = new System.Drawing.Point(71, 153);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(45, 99);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 12;
            this.car1.TabStop = false;
            this.car1.Click += new System.EventHandler(this.car1_Click);
            // 
            // car3
            // 
            this.car3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.car3.Image = global::F_Project.Properties.Resources.car1;
            this.car3.Location = new System.Drawing.Point(496, 265);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(45, 99);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 11;
            this.car3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // L8
            // 
            this.L8.BackColor = System.Drawing.Color.White;
            this.L8.Location = new System.Drawing.Point(511, 192);
            this.L8.Name = "L8";
            this.L8.Size = new System.Drawing.Size(10, 139);
            this.L8.TabIndex = 8;
            this.L8.TabStop = false;
            // 
            // L7
            // 
            this.L7.BackColor = System.Drawing.Color.Gold;
            this.L7.Location = new System.Drawing.Point(511, 23);
            this.L7.Name = "L7";
            this.L7.Size = new System.Drawing.Size(10, 139);
            this.L7.TabIndex = 7;
            this.L7.TabStop = false;
            // 
            // L9
            // 
            this.L9.BackColor = System.Drawing.Color.Black;
            this.L9.Location = new System.Drawing.Point(511, 360);
            this.L9.Name = "L9";
            this.L9.Size = new System.Drawing.Size(10, 139);
            this.L9.TabIndex = 6;
            this.L9.TabStop = false;
            // 
            // L5
            // 
            this.L5.BackColor = System.Drawing.Color.White;
            this.L5.Location = new System.Drawing.Point(295, 192);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(10, 139);
            this.L5.TabIndex = 5;
            this.L5.TabStop = false;
            // 
            // L4
            // 
            this.L4.BackColor = System.Drawing.Color.Gold;
            this.L4.Location = new System.Drawing.Point(295, 23);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(10, 139);
            this.L4.TabIndex = 4;
            this.L4.TabStop = false;
            this.L4.Click += new System.EventHandler(this.L4_Click);
            // 
            // L6
            // 
            this.L6.BackColor = System.Drawing.Color.Black;
            this.L6.Location = new System.Drawing.Point(295, 360);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(10, 139);
            this.L6.TabIndex = 3;
            this.L6.TabStop = false;
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.Color.White;
            this.L2.Location = new System.Drawing.Point(85, 192);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(10, 139);
            this.L2.TabIndex = 2;
            this.L2.TabStop = false;
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.Color.Gold;
            this.L1.Location = new System.Drawing.Point(85, 23);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(10, 139);
            this.L1.TabIndex = 1;
            this.L1.TabStop = false;
            this.L1.Click += new System.EventHandler(this.L1_Click);
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.Color.Black;
            this.L3.Location = new System.Drawing.Point(85, 360);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(10, 139);
            this.L3.TabIndex = 0;
            this.L3.TabStop = false;
            // 
            // timeAction
            // 
            this.timeAction.Enabled = true;
            this.timeAction.Interval = 15;
            this.timeAction.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbwait
            // 
            this.lbwait.AutoSize = true;
            this.lbwait.Font = new System.Drawing.Font("Gabriola", 15F, System.Drawing.FontStyle.Bold);
            this.lbwait.Location = new System.Drawing.Point(431, 9);
            this.lbwait.Name = "lbwait";
            this.lbwait.Size = new System.Drawing.Size(233, 46);
            this.lbwait.TabIndex = 1;
            this.lbwait.Text = "Press Enter to play again";
            this.lbwait.Visible = false;
            this.lbwait.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timerwait
            // 
            this.timerwait.Interval = 300;
            this.timerwait.Tick += new System.EventHandler(this.timerwait_Tick);
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.BackColor = System.Drawing.Color.White;
            this.lbscore.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbscore.Location = new System.Drawing.Point(12, 22);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(69, 21);
            this.lbscore.TabIndex = 15;
            this.lbscore.Text = "Score :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 619);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.lbwait);
            this.Controls.Add(this.panalGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Car Racing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panalGame.ResumeLayout(false);
            this.panalGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timeAction;
        public System.Windows.Forms.Panel panalGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox Player;
        public System.Windows.Forms.PictureBox car1;
        public System.Windows.Forms.PictureBox car3;
        public System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox L9;
        private System.Windows.Forms.PictureBox L8;
        private System.Windows.Forms.PictureBox L6;
        private System.Windows.Forms.PictureBox L3;
        private System.Windows.Forms.PictureBox L7;
        private System.Windows.Forms.PictureBox L5;
        private System.Windows.Forms.PictureBox L4;
        private System.Windows.Forms.PictureBox L2;
        private System.Windows.Forms.PictureBox L1;
        private System.Windows.Forms.Label labGameOver;
        private System.Windows.Forms.Label lbwait;
        private System.Windows.Forms.Timer timerwait;
        private System.Windows.Forms.Label lbscore;
    }
}

