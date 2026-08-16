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
            this.btnRestartGame = new System.Windows.Forms.Button();
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
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestartGame.Location = new System.Drawing.Point(301, 449);
            this.btnRestartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(222, 79);
            this.btnRestartGame.TabIndex = 7;
            this.btnRestartGame.Text = "Start Game";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // lblPlayer2Title
            // 
            this.lblPlayer2Title.AutoSize = true;
            this.lblPlayer2Title.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Title.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblPlayer2Title.Location = new System.Drawing.Point(237, 22);
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
            this.label2.Location = new System.Drawing.Point(471, 22);
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
            this.lblTurnPlayer.Location = new System.Drawing.Point(7, 22);
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
            this.txtPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtPlayer1Name.Location = new System.Drawing.Point(14, 86);
            this.txtPlayer1Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayer1Name.Multiline = true;
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(157, 31);
            this.txtPlayer1Name.TabIndex = 3;
            this.txtPlayer1Name.Text = "Player 1 Name";
            this.txtPlayer1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayer1Name.WordWrap = false;
            // 
            // rbComputer
            // 
            this.rbComputer.AutoSize = true;
            this.rbComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.rbComputer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbComputer.Location = new System.Drawing.Point(539, 182);
            this.rbComputer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbComputer.Name = "rbComputer";
            this.rbComputer.Size = new System.Drawing.Size(164, 40);
            this.rbComputer.TabIndex = 2;
            this.rbComputer.Text = "Computer";
            this.rbComputer.UseVisualStyleBackColor = true;
            this.rbComputer.CheckedChanged += new System.EventHandler(this.rbComputer_CheckedChanged);
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtPlayer2Name.Location = new System.Drawing.Point(244, 86);
            this.txtPlayer2Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayer2Name.Multiline = true;
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(157, 31);
            this.txtPlayer2Name.TabIndex = 4;
            this.txtPlayer2Name.Text = "Player 2 Name";
            this.txtPlayer2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayer2Name.WordWrap = false;
            // 
            // rbFriend
            // 
            this.rbFriend.AutoSize = true;
            this.rbFriend.Checked = true;
            this.rbFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.rbFriend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFriend.Location = new System.Drawing.Point(340, 181);
            this.rbFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFriend.Name = "rbFriend";
            this.rbFriend.Size = new System.Drawing.Size(121, 40);
            this.rbFriend.TabIndex = 1;
            this.rbFriend.TabStop = true;
            this.rbFriend.Text = "Friend";
            this.rbFriend.UseVisualStyleBackColor = true;
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
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.checkBox1.Location = new System.Drawing.Point(563, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 42);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Open";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.numericUpDown1.Location = new System.Drawing.Point(479, 80);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.lblTitle.Location = new System.Drawing.Point(247, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 42);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(829, 580);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.rbComputer);
            this.Controls.Add(this.rbFriend);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRestartGame;
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
    }
}