namespace _3.Tic_Tac_Toe_Game
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblPlayer2Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurnPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.rbComputer = new System.Windows.Forms.RadioButton();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.rbFriend = new System.Windows.Forms.RadioButton();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbEasy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbMedium = new System.Windows.Forms.PictureBox();
            this.pbHard = new System.Windows.Forms.PictureBox();
            this.gbGameLevel = new System.Windows.Forms.GroupBox();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHard)).BeginInit();
            this.gbGameLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Papyrus", 20F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.Location = new System.Drawing.Point(303, 489);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(222, 79);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblPlayer2Title
            // 
            this.lblPlayer2Title.AutoSize = true;
            this.lblPlayer2Title.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Title.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblPlayer2Title.Location = new System.Drawing.Point(237, 24);
            this.lblPlayer2Title.Name = "lblPlayer2Title";
            this.lblPlayer2Title.Size = new System.Drawing.Size(164, 42);
            this.lblPlayer2Title.TabIndex = 46;
            this.lblPlayer2Title.Text = "Player2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(471, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 42);
            this.label2.TabIndex = 45;
            this.label2.Text = "How Many";
            // 
            // lblTurnPlayer
            // 
            this.lblTurnPlayer.AutoSize = true;
            this.lblTurnPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnPlayer.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblTurnPlayer.Location = new System.Drawing.Point(7, 24);
            this.lblTurnPlayer.Name = "lblTurnPlayer";
            this.lblTurnPlayer.Size = new System.Drawing.Size(163, 42);
            this.lblTurnPlayer.TabIndex = 44;
            this.lblTurnPlayer.Text = "Player1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(52, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 42);
            this.label1.TabIndex = 43;
            this.label1.Text = "Play With";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Font = new System.Drawing.Font("Papyrus", 12.8F);
            this.txtPlayer1Name.Location = new System.Drawing.Point(14, 86);
            this.txtPlayer1Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayer1Name.MaxLength = 9;
            this.txtPlayer1Name.Multiline = true;
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(157, 31);
            this.txtPlayer1Name.TabIndex = 3;
            this.txtPlayer1Name.Text = "Player1";
            this.txtPlayer1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayer1Name.WordWrap = false;
            this.txtPlayer1Name.MouseEnter += new System.EventHandler(this.txtPlayer2Name_MouseEnter);
            // 
            // rbComputer
            // 
            this.rbComputer.AutoSize = true;
            this.rbComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbComputer.Font = new System.Drawing.Font("Papyrus", 17.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.rbComputer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbComputer.Location = new System.Drawing.Point(539, 182);
            this.rbComputer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbComputer.Name = "rbComputer";
            this.rbComputer.Size = new System.Drawing.Size(176, 39);
            this.rbComputer.TabIndex = 2;
            this.rbComputer.Text = "Computer";
            this.rbComputer.UseVisualStyleBackColor = true;
            this.rbComputer.CheckedChanged += new System.EventHandler(this.rbComputer_CheckedChanged);
            this.rbComputer.MouseEnter += new System.EventHandler(this.ctrl_MouseEnter);
            this.rbComputer.MouseLeave += new System.EventHandler(this.ctrl_MouseLeave);
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Font = new System.Drawing.Font("Papyrus", 12.8F);
            this.txtPlayer2Name.Location = new System.Drawing.Point(244, 86);
            this.txtPlayer2Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayer2Name.MaxLength = 9;
            this.txtPlayer2Name.Multiline = true;
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(157, 31);
            this.txtPlayer2Name.TabIndex = 4;
            this.txtPlayer2Name.Text = "Player2";
            this.txtPlayer2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayer2Name.WordWrap = false;
            this.txtPlayer2Name.MouseEnter += new System.EventHandler(this.txtPlayer2Name_MouseEnter);
            // 
            // rbFriend
            // 
            this.rbFriend.AutoSize = true;
            this.rbFriend.Checked = true;
            this.rbFriend.Font = new System.Drawing.Font("Papyrus", 17.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.rbFriend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFriend.Location = new System.Drawing.Point(340, 181);
            this.rbFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFriend.Name = "rbFriend";
            this.rbFriend.Size = new System.Drawing.Size(127, 39);
            this.rbFriend.TabIndex = 1;
            this.rbFriend.TabStop = true;
            this.rbFriend.Text = "Friend";
            this.rbFriend.UseVisualStyleBackColor = true;
            this.rbFriend.MouseEnter += new System.EventHandler(this.ctrl_MouseEnter);
            this.rbFriend.MouseLeave += new System.EventHandler(this.ctrl_MouseLeave);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.checkBox1);
            this.gbDetails.Controls.Add(this.numericUpDown1);
            this.gbDetails.Controls.Add(this.lblTurnPlayer);
            this.gbDetails.Controls.Add(this.lblPlayer2Title);
            this.gbDetails.Controls.Add(this.txtPlayer1Name);
            this.gbDetails.Controls.Add(this.txtPlayer2Name);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Font = new System.Drawing.Font("Papyrus", 9.8F, System.Drawing.FontStyle.Bold);
            this.gbDetails.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbDetails.Location = new System.Drawing.Point(60, 240);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetails.Size = new System.Drawing.Size(714, 151);
            this.gbDetails.TabIndex = 52;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details..";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Papyrus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.checkBox1.Location = new System.Drawing.Point(563, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 42);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Open";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.numericUpDown1.Location = new System.Drawing.Point(479, 80);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 43);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(276, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 42);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 42);
            this.label3.TabIndex = 43;
            this.label3.Text = "Game Level";
            // 
            // pbEasy
            // 
            this.pbEasy.BackColor = System.Drawing.Color.Transparent;
            this.pbEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbEasy.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Easy_Level__2_;
            this.pbEasy.Location = new System.Drawing.Point(208, 27);
            this.pbEasy.Margin = new System.Windows.Forms.Padding(2);
            this.pbEasy.Name = "pbEasy";
            this.pbEasy.Size = new System.Drawing.Size(126, 34);
            this.pbEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEasy.TabIndex = 60;
            this.pbEasy.TabStop = false;
            this.pbEasy.Tag = "0";
            this.pbEasy.Click += new System.EventHandler(this.GameLevel_ClickEvent);
            this.pbEasy.MouseEnter += new System.EventHandler(this.ctrl_MouseEnter);
            this.pbEasy.MouseLeave += new System.EventHandler(this.ctrl_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.XOGame;
            this.pictureBox1.Location = new System.Drawing.Point(369, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.ctrl_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Minimize_Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(737, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 48);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Close_Window4;
            this.btnClose.Location = new System.Drawing.Point(774, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 48);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbMedium
            // 
            this.pbMedium.BackColor = System.Drawing.Color.Transparent;
            this.pbMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMedium.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Medium_Level__2_;
            this.pbMedium.Location = new System.Drawing.Point(386, 27);
            this.pbMedium.Margin = new System.Windows.Forms.Padding(2);
            this.pbMedium.Name = "pbMedium";
            this.pbMedium.Size = new System.Drawing.Size(126, 34);
            this.pbMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMedium.TabIndex = 60;
            this.pbMedium.TabStop = false;
            this.pbMedium.Tag = "1";
            this.pbMedium.Click += new System.EventHandler(this.GameLevel_ClickEvent);
            this.pbMedium.MouseEnter += new System.EventHandler(this.ctrl_MouseEnter);
            this.pbMedium.MouseLeave += new System.EventHandler(this.ctrl_MouseLeave);
            // 
            // pbHard
            // 
            this.pbHard.BackColor = System.Drawing.Color.Transparent;
            this.pbHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbHard.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Hard_Level__2_;
            this.pbHard.Location = new System.Drawing.Point(564, 26);
            this.pbHard.Margin = new System.Windows.Forms.Padding(2);
            this.pbHard.Name = "pbHard";
            this.pbHard.Size = new System.Drawing.Size(126, 34);
            this.pbHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHard.TabIndex = 60;
            this.pbHard.TabStop = false;
            this.pbHard.Tag = "2";
            this.pbHard.Click += new System.EventHandler(this.GameLevel_ClickEvent);
            this.pbHard.MouseEnter += new System.EventHandler(this.ctrl_MouseEnter);
            this.pbHard.MouseLeave += new System.EventHandler(this.ctrl_MouseLeave);
            // 
            // gbGameLevel
            // 
            this.gbGameLevel.Controls.Add(this.pbHard);
            this.gbGameLevel.Controls.Add(this.pbEasy);
            this.gbGameLevel.Controls.Add(this.pbMedium);
            this.gbGameLevel.Controls.Add(this.label3);
            this.gbGameLevel.Font = new System.Drawing.Font("Papyrus", 9.8F, System.Drawing.FontStyle.Bold);
            this.gbGameLevel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbGameLevel.Location = new System.Drawing.Point(58, 399);
            this.gbGameLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGameLevel.Name = "gbGameLevel";
            this.gbGameLevel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGameLevel.Size = new System.Drawing.Size(714, 81);
            this.gbGameLevel.TabIndex = 53;
            this.gbGameLevel.TabStop = false;
            this.gbGameLevel.Text = "Difficulty";
            this.gbGameLevel.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(829, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.rbComputer);
            this.Controls.Add(this.rbFriend);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbGameLevel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Underline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHard)).EndInit();
            this.gbGameLevel.ResumeLayout(false);
            this.gbGameLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblPlayer2Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurnPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.RadioButton rbComputer;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.RadioButton rbFriend;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbEasy;
        private System.Windows.Forms.PictureBox pbMedium;
        private System.Windows.Forms.PictureBox pbHard;
        private System.Windows.Forms.GroupBox gbGameLevel;
    }
}