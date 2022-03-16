
namespace Shaun_FootballGame_Jan1022
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRunPlay = new System.Windows.Forms.RadioButton();
            this.radPassPlay = new System.Windows.Forms.RadioButton();
            this.radSTPlay = new System.Windows.Forms.RadioButton();
            this.btnBreakHuddle = new System.Windows.Forms.Button();
            this.gbSpecialTeams = new System.Windows.Forms.GroupBox();
            this.radPuntPlay = new System.Windows.Forms.RadioButton();
            this.radFGPlay = new System.Windows.Forms.RadioButton();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTeam1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScoreTeam2 = new System.Windows.Forms.Label();
            this.lblCurrentDown = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblCurrentYL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSpecialTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a play";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSTPlay);
            this.groupBox1.Controls.Add(this.radPassPlay);
            this.groupBox1.Controls.Add(this.radRunPlay);
            this.groupBox1.Location = new System.Drawing.Point(24, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radRunPlay
            // 
            this.radRunPlay.AutoSize = true;
            this.radRunPlay.Location = new System.Drawing.Point(11, 38);
            this.radRunPlay.Name = "radRunPlay";
            this.radRunPlay.Size = new System.Drawing.Size(55, 21);
            this.radRunPlay.TabIndex = 0;
            this.radRunPlay.TabStop = true;
            this.radRunPlay.Text = "Run";
            this.radRunPlay.UseVisualStyleBackColor = true;
            // 
            // radPassPlay
            // 
            this.radPassPlay.AutoSize = true;
            this.radPassPlay.Location = new System.Drawing.Point(11, 80);
            this.radPassPlay.Name = "radPassPlay";
            this.radPassPlay.Size = new System.Drawing.Size(60, 21);
            this.radPassPlay.TabIndex = 1;
            this.radPassPlay.TabStop = true;
            this.radPassPlay.Text = "Pass";
            this.radPassPlay.UseVisualStyleBackColor = true;
            // 
            // radSTPlay
            // 
            this.radSTPlay.AutoSize = true;
            this.radSTPlay.Location = new System.Drawing.Point(11, 117);
            this.radSTPlay.Name = "radSTPlay";
            this.radSTPlay.Size = new System.Drawing.Size(122, 21);
            this.radSTPlay.TabIndex = 2;
            this.radSTPlay.TabStop = true;
            this.radSTPlay.Text = "Special Teams";
            this.radSTPlay.UseVisualStyleBackColor = true;
            this.radSTPlay.CheckedChanged += new System.EventHandler(this.radSTPlay_CheckedChanged);
            // 
            // btnBreakHuddle
            // 
            this.btnBreakHuddle.Location = new System.Drawing.Point(522, 205);
            this.btnBreakHuddle.Name = "btnBreakHuddle";
            this.btnBreakHuddle.Size = new System.Drawing.Size(194, 44);
            this.btnBreakHuddle.TabIndex = 3;
            this.btnBreakHuddle.Text = "Break Huddle";
            this.btnBreakHuddle.UseVisualStyleBackColor = true;
            this.btnBreakHuddle.Click += new System.EventHandler(this.btnBreakHuddle_Click);
            // 
            // gbSpecialTeams
            // 
            this.gbSpecialTeams.Controls.Add(this.radPuntPlay);
            this.gbSpecialTeams.Controls.Add(this.radFGPlay);
            this.gbSpecialTeams.Location = new System.Drawing.Point(280, 100);
            this.gbSpecialTeams.Name = "gbSpecialTeams";
            this.gbSpecialTeams.Size = new System.Drawing.Size(200, 114);
            this.gbSpecialTeams.TabIndex = 4;
            this.gbSpecialTeams.TabStop = false;
            this.gbSpecialTeams.Text = "Special Teams Play";
            this.gbSpecialTeams.Visible = false;
            // 
            // radPuntPlay
            // 
            this.radPuntPlay.AutoSize = true;
            this.radPuntPlay.Location = new System.Drawing.Point(11, 80);
            this.radPuntPlay.Name = "radPuntPlay";
            this.radPuntPlay.Size = new System.Drawing.Size(58, 21);
            this.radPuntPlay.TabIndex = 1;
            this.radPuntPlay.TabStop = true;
            this.radPuntPlay.Text = "Punt";
            this.radPuntPlay.UseVisualStyleBackColor = true;
            // 
            // radFGPlay
            // 
            this.radFGPlay.AutoSize = true;
            this.radFGPlay.Location = new System.Drawing.Point(11, 38);
            this.radFGPlay.Name = "radFGPlay";
            this.radFGPlay.Size = new System.Drawing.Size(93, 21);
            this.radFGPlay.TabIndex = 0;
            this.radFGPlay.TabStop = true;
            this.radFGPlay.Text = "Field Goal";
            this.radFGPlay.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(528, 33);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 17);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreTeam1
            // 
            this.lblScoreTeam1.AutoSize = true;
            this.lblScoreTeam1.Location = new System.Drawing.Point(584, 32);
            this.lblScoreTeam1.Name = "lblScoreTeam1";
            this.lblScoreTeam1.Size = new System.Drawing.Size(16, 17);
            this.lblScoreTeam1.TabIndex = 6;
            this.lblScoreTeam1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // lblScoreTeam2
            // 
            this.lblScoreTeam2.AutoSize = true;
            this.lblScoreTeam2.Location = new System.Drawing.Point(649, 32);
            this.lblScoreTeam2.Name = "lblScoreTeam2";
            this.lblScoreTeam2.Size = new System.Drawing.Size(16, 17);
            this.lblScoreTeam2.TabIndex = 8;
            this.lblScoreTeam2.Text = "0";
            // 
            // lblCurrentDown
            // 
            this.lblCurrentDown.AutoSize = true;
            this.lblCurrentDown.Location = new System.Drawing.Point(526, 77);
            this.lblCurrentDown.Name = "lblCurrentDown";
            this.lblCurrentDown.Size = new System.Drawing.Size(51, 17);
            this.lblCurrentDown.TabIndex = 9;
            this.lblCurrentDown.Text = "Down: ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(528, 121);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(83, 17);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "Ball on the :";
            // 
            // lblCurrentYL
            // 
            this.lblCurrentYL.AutoSize = true;
            this.lblCurrentYL.Location = new System.Drawing.Point(619, 121);
            this.lblCurrentYL.Name = "lblCurrentYL";
            this.lblCurrentYL.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentYL.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 519);
            this.Controls.Add(this.lblCurrentYL);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblCurrentDown);
            this.Controls.Add(this.lblScoreTeam2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScoreTeam1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.gbSpecialTeams);
            this.Controls.Add(this.btnBreakHuddle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSpecialTeams.ResumeLayout(false);
            this.gbSpecialTeams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSTPlay;
        private System.Windows.Forms.RadioButton radPassPlay;
        private System.Windows.Forms.RadioButton radRunPlay;
        private System.Windows.Forms.Button btnBreakHuddle;
        private System.Windows.Forms.GroupBox gbSpecialTeams;
        private System.Windows.Forms.RadioButton radPuntPlay;
        private System.Windows.Forms.RadioButton radFGPlay;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTeam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScoreTeam2;
        private System.Windows.Forms.Label lblCurrentDown;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblCurrentYL;
    }
}

