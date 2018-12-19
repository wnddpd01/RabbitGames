namespace sosil3_homework
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_Star = new System.Windows.Forms.Label();
            this.label_health = new System.Windows.Forms.Label();
            this.label_Speed = new System.Windows.Forms.Label();
            this.btn_Manual = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_highScore = new System.Windows.Forms.Button();
            this.btn_Start_fake = new System.Windows.Forms.Button();
            this.pictureBox_cloud = new System.Windows.Forms.PictureBox();
            this.pictureBox_nomal_rabbit = new System.Windows.Forms.PictureBox();
            this.pictureBox_background = new System.Windows.Forms.PictureBox();
            this.pictureBox_left = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nomal_rabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label_Level);
            this.groupBox1.Controls.Add(this.label_Score);
            this.groupBox1.Controls.Add(this.label_Star);
            this.groupBox1.Controls.Add(this.label_health);
            this.groupBox1.Controls.Add(this.label_Speed);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 203);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State Box";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Location = new System.Drawing.Point(25, 124);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(71, 12);
            this.label_Score.TabIndex = 6;
            this.label_Score.Text = "label_Score";
            // 
            // label_Star
            // 
            this.label_Star.AutoSize = true;
            this.label_Star.Location = new System.Drawing.Point(25, 80);
            this.label_Star.Name = "label_Star";
            this.label_Star.Size = new System.Drawing.Size(60, 12);
            this.label_Star.TabIndex = 7;
            this.label_Star.Text = "label_Star";
            // 
            // label_health
            // 
            this.label_health.AutoSize = true;
            this.label_health.Location = new System.Drawing.Point(25, 59);
            this.label_health.Name = "label_health";
            this.label_health.Size = new System.Drawing.Size(72, 12);
            this.label_health.TabIndex = 6;
            this.label_health.Text = "label_health";
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Location = new System.Drawing.Point(25, 102);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(74, 12);
            this.label_Speed.TabIndex = 0;
            this.label_Speed.Text = "label_Speed";
            // 
            // btn_Manual
            // 
            this.btn_Manual.Location = new System.Drawing.Point(39, 290);
            this.btn_Manual.Name = "btn_Manual";
            this.btn_Manual.Size = new System.Drawing.Size(75, 23);
            this.btn_Manual.TabIndex = 8;
            this.btn_Manual.TabStop = false;
            this.btn_Manual.Text = "Manual";
            this.btn_Manual.UseVisualStyleBackColor = true;
            this.btn_Manual.Click += new System.EventHandler(this.btn_Manual_Click);
            this.btn_Manual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(39, 319);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.TabStop = false;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            this.btn_Start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Location = new System.Drawing.Point(39, 348);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_highScore
            // 
            this.btn_highScore.Location = new System.Drawing.Point(39, 242);
            this.btn_highScore.Name = "btn_highScore";
            this.btn_highScore.Size = new System.Drawing.Size(96, 23);
            this.btn_highScore.TabIndex = 10;
            this.btn_highScore.Text = "HighScores";
            this.btn_highScore.UseVisualStyleBackColor = true;
            this.btn_highScore.Click += new System.EventHandler(this.btn_highScore_Click);
            this.btn_highScore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // btn_Start_fake
            // 
            this.btn_Start_fake.Enabled = false;
            this.btn_Start_fake.Location = new System.Drawing.Point(39, 319);
            this.btn_Start_fake.Name = "btn_Start_fake";
            this.btn_Start_fake.Size = new System.Drawing.Size(75, 23);
            this.btn_Start_fake.TabIndex = 11;
            this.btn_Start_fake.Text = "Start";
            this.btn_Start_fake.UseVisualStyleBackColor = true;
            // 
            // pictureBox_cloud
            // 
            this.pictureBox_cloud.Image = global::sosil3_homework.Properties.Resources.구름;
            this.pictureBox_cloud.Location = new System.Drawing.Point(183, 12);
            this.pictureBox_cloud.Name = "pictureBox_cloud";
            this.pictureBox_cloud.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cloud.TabIndex = 3;
            this.pictureBox_cloud.TabStop = false;
            // 
            // pictureBox_nomal_rabbit
            // 
            this.pictureBox_nomal_rabbit.Image = global::sosil3_homework.Properties.Resources.rabbit;
            this.pictureBox_nomal_rabbit.Location = new System.Drawing.Point(183, 278);
            this.pictureBox_nomal_rabbit.Name = "pictureBox_nomal_rabbit";
            this.pictureBox_nomal_rabbit.Size = new System.Drawing.Size(59, 79);
            this.pictureBox_nomal_rabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_nomal_rabbit.TabIndex = 2;
            this.pictureBox_nomal_rabbit.TabStop = false;
            // 
            // pictureBox_background
            // 
            this.pictureBox_background.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_background.Image")));
            this.pictureBox_background.Location = new System.Drawing.Point(170, 0);
            this.pictureBox_background.Name = "pictureBox_background";
            this.pictureBox_background.Size = new System.Drawing.Size(574, 408);
            this.pictureBox_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_background.TabIndex = 1;
            this.pictureBox_background.TabStop = false;
            // 
            // pictureBox_left
            // 
            this.pictureBox_left.Image = global::sosil3_homework.Properties.Resources.왼쪽;
            this.pictureBox_left.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_left.Name = "pictureBox_left";
            this.pictureBox_left.Size = new System.Drawing.Size(164, 408);
            this.pictureBox_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_left.TabIndex = 0;
            this.pictureBox_left.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(253, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 100);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Location = new System.Drawing.Point(25, 145);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(68, 12);
            this.label_Level.TabIndex = 13;
            this.label_Level.Text = "label_Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Start_fake);
            this.Controls.Add(this.btn_highScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Manual);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_cloud);
            this.Controls.Add(this.pictureBox_nomal_rabbit);
            this.Controls.Add(this.pictureBox_background);
            this.Controls.Add(this.pictureBox_left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nomal_rabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_left;
        private System.Windows.Forms.PictureBox pictureBox_background;
        private System.Windows.Forms.PictureBox pictureBox_nomal_rabbit;
        private System.Windows.Forms.PictureBox pictureBox_cloud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Label label_health;
        private System.Windows.Forms.Label label_Star;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Button btn_Manual;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_highScore;
        private System.Windows.Forms.Button btn_Start_fake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Level;
    }
}

