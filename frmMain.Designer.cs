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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Papyrus", 20F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.Location = new System.Drawing.Point(301, 449);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(222, 79);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            this.btnStartGame.MouseEnter += new System.EventHandler(this.btnStartGame_MouseEnter);
            // 
            // lblPlayer2Title
            // 
            this.lblPlayer2Title.AutoSize = true;
            this.lblPlayer2Title.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Title.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblPlayer2Title.Location = new System.Drawing.Point(237, 22);
            this.lblPlayer2Title.Name = "lblPlayer2Title";
            this.lblPlayer2Title.Size = new System.Drawing.Size(135, 33);
            this.lblPlayer2Title.TabIndex = 46;
            this.lblPlayer2Title.Text = "Player2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(471, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 33);
            this.label2.TabIndex = 45;
            this.label2.Text = "How Many";
            // 
            // lblTurnPlayer
            // 
            this.lblTurnPlayer.AutoSize = true;
            this.lblTurnPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnPlayer.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblTurnPlayer.Location = new System.Drawing.Point(7, 22);
            this.lblTurnPlayer.Name = "lblTurnPlayer";
            this.lblTurnPlayer.Size = new System.Drawing.Size(134, 33);
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
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Play With";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Font = new System.Drawing.Font("Papyrus", 12.8F);
            this.txtPlayer1Name.Location = new System.Drawing.Point(14, 86);
            this.txtPlayer1Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayer1Name.MaxLength = 25;
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
            this.rbComputer.Size = new System.Drawing.Size(143, 33);
            this.rbComputer.TabIndex = 2;
            this.rbComputer.Text = "Computer";
            this.rbComputer.UseVisualStyleBackColor = true;
            this.rbComputer.CheckedChanged += new System.EventHandler(this.rbComputer_CheckedChanged);
            this.rbComputer.MouseEnter += new System.EventHandler(this.btnStartGame_MouseEnter);
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Font = new System.Drawing.Font("Papyrus", 12.8F);
            this.txtPlayer2Name.Location = new System.Drawing.Point(244, 86);
            this.txtPlayer2Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayer2Name.MaxLength = 25;
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
            this.rbFriend.Size = new System.Drawing.Size(105, 33);
            this.rbFriend.TabIndex = 1;
            this.rbFriend.TabStop = true;
            this.rbFriend.Text = "Friend";
            this.rbFriend.UseVisualStyleBackColor = true;
            this.rbFriend.MouseEnter += new System.EventHandler(this.btnStartGame_MouseEnter);
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
            this.checkBox1.Size = new System.Drawing.Size(103, 36);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Open";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseEnter += new System.EventHandler(this.btnStartGame_MouseEnter);
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
            this.numericUpDown1.Size = new System.Drawing.Size(64, 36);
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
            this.lblTitle.Size = new System.Drawing.Size(273, 33);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}