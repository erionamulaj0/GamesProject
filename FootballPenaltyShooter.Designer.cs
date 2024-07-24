namespace GamesProject
{
    partial class FootballPenaltyShooter
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.topLeft = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.topRight = new System.Windows.Forms.PictureBox();
            this.goalKeeper = new System.Windows.Forms.PictureBox();
            this.football = new System.Windows.Forms.PictureBox();
            this.KeeperTimer = new System.Windows.Forms.Timer(this.components);
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            this.goBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblScore.Location = new System.Drawing.Point(12, 21);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(95, 32);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: ";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.BackColor = System.Drawing.Color.Transparent;
            this.lblMissed.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMissed.Location = new System.Drawing.Point(752, 21);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(114, 32);
            this.lblMissed.TabIndex = 1;
            this.lblMissed.Text = "Missed: ";
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Yellow;
            this.left.Image = global::GamesProject.Properties.Resources.target;
            this.left.Location = new System.Drawing.Point(201, 238);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(40, 40);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.left.TabIndex = 2;
            this.left.TabStop = false;
            this.left.Tag = "left";
            this.left.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Yellow;
            this.right.Image = global::GamesProject.Properties.Resources.target;
            this.right.Location = new System.Drawing.Point(675, 238);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(40, 40);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.right.TabIndex = 3;
            this.right.TabStop = false;
            this.right.Tag = "right";
            this.right.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topLeft
            // 
            this.topLeft.BackColor = System.Drawing.Color.Yellow;
            this.topLeft.Image = global::GamesProject.Properties.Resources.target;
            this.topLeft.Location = new System.Drawing.Point(201, 78);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(40, 40);
            this.topLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topLeft.TabIndex = 4;
            this.topLeft.TabStop = false;
            this.topLeft.Tag = "topLeft";
            this.topLeft.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Yellow;
            this.top.Image = global::GamesProject.Properties.Resources.target;
            this.top.Location = new System.Drawing.Point(437, 76);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(40, 40);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 5;
            this.top.TabStop = false;
            this.top.Tag = "top";
            this.top.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.Yellow;
            this.topRight.Image = global::GamesProject.Properties.Resources.target;
            this.topRight.Location = new System.Drawing.Point(675, 76);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(40, 40);
            this.topRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topRight.TabIndex = 6;
            this.topRight.TabStop = false;
            this.topRight.Tag = "topRight";
            this.topRight.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // goalKeeper
            // 
            this.goalKeeper.BackColor = System.Drawing.Color.Transparent;
            this.goalKeeper.Image = global::GamesProject.Properties.Resources.stand_small;
            this.goalKeeper.Location = new System.Drawing.Point(418, 169);
            this.goalKeeper.Name = "goalKeeper";
            this.goalKeeper.Size = new System.Drawing.Size(82, 126);
            this.goalKeeper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goalKeeper.TabIndex = 7;
            this.goalKeeper.TabStop = false;
            this.goalKeeper.Click += new System.EventHandler(this.goalKeeper_Click);
            // 
            // football
            // 
            this.football.BackColor = System.Drawing.Color.Transparent;
            this.football.BackgroundImage = global::GamesProject.Properties.Resources.football;
            this.football.Location = new System.Drawing.Point(430, 500);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(50, 51);
            this.football.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.football.TabIndex = 8;
            this.football.TabStop = false;
            // 
            // KeeperTimer
            // 
            this.KeeperTimer.Interval = 20;
            this.KeeperTimer.Tick += new System.EventHandler(this.KeeperTimerEvent);
            // 
            // BallTimer
            // 
            this.BallTimer.Interval = 20;
            this.BallTimer.Tick += new System.EventHandler(this.BallTimerEvent);
            // 
            // goBack
            // 
            this.goBack.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.goBack.AutoSize = true;
            this.goBack.BackColor = System.Drawing.Color.Transparent;
            this.goBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.goBack.Location = new System.Drawing.Point(776, 638);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(109, 23);
            this.goBack.TabIndex = 17;
            this.goBack.TabStop = true;
            this.goBack.Text = "Go Back →";
            this.goBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goBack_LinkClicked);
            // 
            // FootballPenaltyShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GamesProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 670);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.football);
            this.Controls.Add(this.goalKeeper);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.top);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FootballPenaltyShooter";
            this.Text = "FootballPenaltyShooter";
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox topLeft;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox topRight;
        private System.Windows.Forms.PictureBox goalKeeper;
        private System.Windows.Forms.PictureBox football;
        private System.Windows.Forms.Timer KeeperTimer;
        private System.Windows.Forms.Timer BallTimer;
        private System.Windows.Forms.LinkLabel goBack;
    }
}