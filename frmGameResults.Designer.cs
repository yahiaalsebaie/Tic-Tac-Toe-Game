namespace _3.Tic_Tac_Toe_Game
{
    partial class frmGameResults
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinnerPlayer = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.lblDrawTimes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.lblP1Wins = new System.Windows.Forms.Label();
            this.lblP2Wins = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.label6.Location = new System.Drawing.Point(927, 778);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 42);
            this.label6.TabIndex = 45;
            this.label6.Tag = "Player1";
            this.label6.Text = "Player1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(299, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 42);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Game Resalts";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestartGame.Location = new System.Drawing.Point(130, 440);
            this.btnRestartGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(246, 79);
            this.btnRestartGame.TabIndex = 40;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(351, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 42);
            this.label2.TabIndex = 38;
            this.label2.Text = "Winner";
            // 
            // lblWinnerPlayer
            // 
            this.lblWinnerPlayer.AutoSize = true;
            this.lblWinnerPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnerPlayer.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblWinnerPlayer.Location = new System.Drawing.Point(351, 347);
            this.lblWinnerPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinnerPlayer.Name = "lblWinnerPlayer";
            this.lblWinnerPlayer.Size = new System.Drawing.Size(163, 42);
            this.lblWinnerPlayer.TabIndex = 37;
            this.lblWinnerPlayer.Tag = "Player1";
            this.lblWinnerPlayer.Text = "Player1";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundNumber.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblRoundNumber.Location = new System.Drawing.Point(342, 108);
            this.lblRoundNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(38, 42);
            this.lblRoundNumber.TabIndex = 35;
            this.lblRoundNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(392, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 42);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rounds";
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMain.Location = new System.Drawing.Point(481, 440);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(246, 79);
            this.btnMain.TabIndex = 40;
            this.btnMain.Text = "Back To Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblP1Name);
            this.groupBox2.Controls.Add(this.lblDrawTimes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblP2Name);
            this.groupBox2.Controls.Add(this.lblP1Wins);
            this.groupBox2.Controls.Add(this.lblP2Wins);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(130, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 109);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Details";
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblP1Name.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblP1Name.Location = new System.Drawing.Point(14, 23);
            this.lblP1Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(163, 42);
            this.lblP1Name.TabIndex = 30;
            this.lblP1Name.Tag = "Player1";
            this.lblP1Name.Text = "Player1";
            // 
            // lblDrawTimes
            // 
            this.lblDrawTimes.AutoSize = true;
            this.lblDrawTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawTimes.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblDrawTimes.Location = new System.Drawing.Point(449, 64);
            this.lblDrawTimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrawTimes.Name = "lblDrawTimes";
            this.lblDrawTimes.Size = new System.Drawing.Size(38, 42);
            this.lblDrawTimes.TabIndex = 47;
            this.lblDrawTimes.Text = "0";
            this.lblDrawTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(449, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 42);
            this.label3.TabIndex = 46;
            this.label3.Text = "Draw";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.BackColor = System.Drawing.Color.Transparent;
            this.lblP2Name.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblP2Name.Location = new System.Drawing.Point(231, 23);
            this.lblP2Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(164, 42);
            this.lblP2Name.TabIndex = 32;
            this.lblP2Name.Tag = "Player2";
            this.lblP2Name.Text = "Player2";
            // 
            // lblP1Wins
            // 
            this.lblP1Wins.AutoSize = true;
            this.lblP1Wins.BackColor = System.Drawing.Color.Transparent;
            this.lblP1Wins.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Wins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblP1Wins.Location = new System.Drawing.Point(15, 66);
            this.lblP1Wins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP1Wins.Name = "lblP1Wins";
            this.lblP1Wins.Size = new System.Drawing.Size(38, 42);
            this.lblP1Wins.TabIndex = 2;
            this.lblP1Wins.Text = "0";
            this.lblP1Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP2Wins
            // 
            this.lblP2Wins.AutoSize = true;
            this.lblP2Wins.BackColor = System.Drawing.Color.Transparent;
            this.lblP2Wins.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Wins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblP2Wins.Location = new System.Drawing.Point(231, 66);
            this.lblP2Wins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP2Wins.Name = "lblP2Wins";
            this.lblP2Wins.Size = new System.Drawing.Size(38, 42);
            this.lblP2Wins.TabIndex = 31;
            this.lblP2Wins.Text = "0";
            this.lblP2Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Close_Window4;
            this.btnClose.Location = new System.Drawing.Point(839, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 48);
            this.btnClose.TabIndex = 52;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Minimize_Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(802, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 48);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGameResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(893, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWinnerPlayer);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGameResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameResults";
            this.Load += new System.EventHandler(this.frmGameResults_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinnerPlayer;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.Label lblDrawTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblP2Name;
        private System.Windows.Forms.Label lblP1Wins;
        private System.Windows.Forms.Label lblP2Wins;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}