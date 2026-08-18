namespace _3.Tic_Tac_Toe_Game
{
    partial class frmTicTacToeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToeGame));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurnPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblGDplayer1 = new System.Windows.Forms.Label();
            this.lblP1Wins = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGDplayer2 = new System.Windows.Forms.Label();
            this.lblP2Wins = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.gbCards = new System.Windows.Forms.GroupBox();
            this.lblShadow = new System.Windows.Forms.Label();
            this.lblFinalRound = new System.Windows.Forms.Label();
            this.lblDrawTimes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAutoRestart = new System.Windows.Forms.CheckBox();
            this.lblRoundTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUseNumpad = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBackToDefault = new System.Windows.Forms.Button();
            this.btnChangeColorMode = new System.Windows.Forms.Button();
            this.btnRestartRound = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.gbCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(180, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            // 
            // lblTurnPlayer
            // 
            this.lblTurnPlayer.AutoSize = true;
            this.lblTurnPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnPlayer.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblTurnPlayer.Location = new System.Drawing.Point(158, 262);
            this.lblTurnPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnPlayer.Name = "lblTurnPlayer";
            this.lblTurnPlayer.Size = new System.Drawing.Size(134, 33);
            this.lblTurnPlayer.TabIndex = 1;
            this.lblTurnPlayer.Tag = "Player1";
            this.lblTurnPlayer.Text = "Player1";
            this.lblTurnPlayer.SizeChanged += new System.EventHandler(this.lblTurnPlayer_SizeChanged);
          //  this.lblTurnPlayer.Click += new System.EventHandler(this.lblTurnPlayer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(161, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblWinner.Location = new System.Drawing.Point(128, 368);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(194, 33);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Tag = "IN PROGRESS";
            this.lblWinner.Text = "IN PROGRESS";
            this.lblWinner.SizeChanged += new System.EventHandler(this.lblWinner_SizeChanged);
            // 
            // lblGDplayer1
            // 
            this.lblGDplayer1.AutoSize = true;
            this.lblGDplayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblGDplayer1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGDplayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblGDplayer1.Location = new System.Drawing.Point(14, 23);
            this.lblGDplayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGDplayer1.Name = "lblGDplayer1";
            this.lblGDplayer1.Size = new System.Drawing.Size(134, 33);
            this.lblGDplayer1.TabIndex = 30;
            this.lblGDplayer1.Tag = "Player1";
            this.lblGDplayer1.Text = "Player1";
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
            this.lblP1Wins.Size = new System.Drawing.Size(32, 33);
            this.lblP1Wins.TabIndex = 2;
            this.lblP1Wins.Text = "0";
            this.lblP1Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.label6.Location = new System.Drawing.Point(1001, 817);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 33);
            this.label6.TabIndex = 30;
            this.label6.Tag = "Player1";
            this.label6.Text = "Player1";
            // 
            // lblGDplayer2
            // 
            this.lblGDplayer2.AutoSize = true;
            this.lblGDplayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblGDplayer2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGDplayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.lblGDplayer2.Location = new System.Drawing.Point(212, 23);
            this.lblGDplayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGDplayer2.Name = "lblGDplayer2";
            this.lblGDplayer2.Size = new System.Drawing.Size(135, 33);
            this.lblGDplayer2.TabIndex = 32;
            this.lblGDplayer2.Tag = "Player2";
            this.lblGDplayer2.Text = "Player2";
            // 
            // lblP2Wins
            // 
            this.lblP2Wins.AutoSize = true;
            this.lblP2Wins.BackColor = System.Drawing.Color.Transparent;
            this.lblP2Wins.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Wins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblP2Wins.Location = new System.Drawing.Point(213, 66);
            this.lblP2Wins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP2Wins.Name = "lblP2Wins";
            this.lblP2Wins.Size = new System.Drawing.Size(32, 33);
            this.lblP2Wins.TabIndex = 31;
            this.lblP2Wins.Text = "0";
            this.lblP2Wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGDplayer1);
            this.groupBox2.Controls.Add(this.lblGDplayer2);
            this.groupBox2.Controls.Add(this.lblP1Wins);
            this.groupBox2.Controls.Add(this.lblP2Wins);
            this.groupBox2.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(574, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 109);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Details";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundNumber.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblRoundNumber.Location = new System.Drawing.Point(195, 156);
            this.lblRoundNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(61, 33);
            this.lblRoundNumber.TabIndex = 0;
            this.lblRoundNumber.Text = "0/0";
            this.lblRoundNumber.SizeChanged += new System.EventHandler(this.lblRoundNumber_SizeChanged);
            this.lblRoundNumber.Click += new System.EventHandler(this.lblRoundNumber_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn9.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Red;
            this.btn9.Location = new System.Drawing.Point(274, 30);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(94, 94);
            this.btn9.TabIndex = 11;
            this.btn9.Tag = "?";
            this.btn9.Text = "?";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            this.btn9.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn9.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn8.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Red;
            this.btn8.Location = new System.Drawing.Point(144, 30);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(94, 94);
            this.btn8.TabIndex = 12;
            this.btn8.Tag = "?";
            this.btn8.Text = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            this.btn8.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn8.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn4.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Red;
            this.btn4.Location = new System.Drawing.Point(14, 161);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(94, 94);
            this.btn4.TabIndex = 10;
            this.btn4.Tag = "?";
            this.btn4.Text = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn7.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Red;
            this.btn7.Location = new System.Drawing.Point(14, 30);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(94, 94);
            this.btn7.TabIndex = 13;
            this.btn7.Tag = "?";
            this.btn7.Text = "?";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            this.btn7.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn7.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn6.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Red;
            this.btn6.Location = new System.Drawing.Point(274, 161);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(94, 94);
            this.btn6.TabIndex = 8;
            this.btn6.Tag = "?";
            this.btn6.Text = "?";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            this.btn6.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn6.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn1.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Red;
            this.btn1.Location = new System.Drawing.Point(14, 289);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 94);
            this.btn1.TabIndex = 7;
            this.btn1.Tag = "?";
            this.btn1.Text = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn2.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.Location = new System.Drawing.Point(144, 289);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 94);
            this.btn2.TabIndex = 6;
            this.btn2.Tag = "?";
            this.btn2.Text = "?";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn3.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(274, 289);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(94, 94);
            this.btn3.TabIndex = 5;
            this.btn3.Tag = "?";
            this.btn3.Text = "?";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn5.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Red;
            this.btn5.Location = new System.Drawing.Point(144, 161);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(94, 94);
            this.btn5.TabIndex = 9;
            this.btn5.Tag = "?";
            this.btn5.Text = "?";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            this.btn5.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn5.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // gbCards
            // 
            this.gbCards.BackColor = System.Drawing.Color.Transparent;
            this.gbCards.Controls.Add(this.btn7);
            this.gbCards.Controls.Add(this.btn9);
            this.gbCards.Controls.Add(this.btn8);
            this.gbCards.Controls.Add(this.btn5);
            this.gbCards.Controls.Add(this.btn3);
            this.gbCards.Controls.Add(this.btn2);
            this.gbCards.Controls.Add(this.btn1);
            this.gbCards.Controls.Add(this.btn6);
            this.gbCards.Controls.Add(this.btn4);
            this.gbCards.Controls.Add(this.lblShadow);
            this.gbCards.Location = new System.Drawing.Point(574, 103);
            this.gbCards.Name = "gbCards";
            this.gbCards.Size = new System.Drawing.Size(376, 406);
            this.gbCards.TabIndex = 28;
            this.gbCards.TabStop = false;
            // 
            // lblShadow
            // 
            this.lblShadow.AutoSize = true;
            this.lblShadow.BackColor = System.Drawing.Color.Transparent;
            this.lblShadow.Font = new System.Drawing.Font("Showcard Gothic", 350F, System.Drawing.FontStyle.Bold);
            this.lblShadow.ForeColor = System.Drawing.Color.Transparent;
            this.lblShadow.Location = new System.Drawing.Point(-77, -100);
            this.lblShadow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShadow.Name = "lblShadow";
            this.lblShadow.Size = new System.Drawing.Size(586, 578);
            this.lblShadow.TabIndex = 2;
            this.lblShadow.Tag = "x";
            this.lblShadow.Text = "x";
            // 
            // lblFinalRound
            // 
            this.lblFinalRound.AutoSize = true;
            this.lblFinalRound.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalRound.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblFinalRound.Location = new System.Drawing.Point(125, 103);
            this.lblFinalRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalRound.Name = "lblFinalRound";
            this.lblFinalRound.Size = new System.Drawing.Size(200, 33);
            this.lblFinalRound.TabIndex = 0;
            this.lblFinalRound.Text = "Final round";
            this.lblFinalRound.Visible = false;
            this.lblFinalRound.TextChanged += new System.EventHandler(this.lblFinalRound_TextChanged);
            // 
            // lblDrawTimes
            // 
            this.lblDrawTimes.AutoSize = true;
            this.lblDrawTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawTimes.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblDrawTimes.Location = new System.Drawing.Point(520, 559);
            this.lblDrawTimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrawTimes.Name = "lblDrawTimes";
            this.lblDrawTimes.Size = new System.Drawing.Size(32, 33);
            this.lblDrawTimes.TabIndex = 31;
            this.lblDrawTimes.Text = "0";
            this.lblDrawTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(384, 559);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Draw:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkAutoRestart
            // 
            this.chkAutoRestart.AutoSize = true;
            this.chkAutoRestart.Checked = true;
            this.chkAutoRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoRestart.FlatAppearance.BorderSize = 2;
            this.chkAutoRestart.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkAutoRestart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkAutoRestart.Font = new System.Drawing.Font("Papyrus", 13.2F, System.Drawing.FontStyle.Bold);
            this.chkAutoRestart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkAutoRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkAutoRestart.Location = new System.Drawing.Point(151, 510);
            this.chkAutoRestart.Name = "chkAutoRestart";
            this.chkAutoRestart.Size = new System.Drawing.Size(149, 32);
            this.chkAutoRestart.TabIndex = 4;
            this.chkAutoRestart.Text = "Auto Restart";
            this.chkAutoRestart.UseVisualStyleBackColor = true;
            this.chkAutoRestart.CheckedChanged += new System.EventHandler(this.chkAutoRestart_CheckedChanged);
            // 
            // lblRoundTitle
            // 
            this.lblRoundTitle.AutoSize = true;
            this.lblRoundTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundTitle.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(228)))), ((int)(((byte)(46)))));
            this.lblRoundTitle.Location = new System.Drawing.Point(168, 103);
            this.lblRoundTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundTitle.Name = "lblRoundTitle";
            this.lblRoundTitle.Size = new System.Drawing.Size(114, 33);
            this.lblRoundTitle.TabIndex = 0;
            this.lblRoundTitle.Text = "Round";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 29F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(328, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(390, 49);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Tic-Tac-Toe Game";
            // 
            // btnUseNumpad
            // 
            this.btnUseNumpad.BackgroundImage = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Keypad;
            this.btnUseNumpad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUseNumpad.FlatAppearance.BorderSize = 0;
            this.btnUseNumpad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(175)))));
            this.btnUseNumpad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseNumpad.Location = new System.Drawing.Point(50, 3);
            this.btnUseNumpad.Name = "btnUseNumpad";
            this.btnUseNumpad.Size = new System.Drawing.Size(42, 48);
            this.btnUseNumpad.TabIndex = 2;
            this.btnUseNumpad.UseVisualStyleBackColor = true;
            this.btnUseNumpad.Click += new System.EventHandler(this.btnUseNumpad_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackgroundImage = global::_3.Tic_Tac_Toe_Game.Properties.Resources.BackToSettings;
            this.btnBackToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackToMain.FlatAppearance.BorderSize = 0;
            this.btnBackToMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(129)))), ((int)(((byte)(175)))));
            this.btnBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMain.Location = new System.Drawing.Point(2, 3);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(42, 48);
            this.btnBackToMain.TabIndex = 1;
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Minimize_Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(913, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 48);
            this.button1.TabIndex = 7;
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
            this.btnClose.Location = new System.Drawing.Point(950, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 48);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBackToDefault
            // 
            this.btnBackToDefault.Font = new System.Drawing.Font("Papyrus", 10.2F);
            this.btnBackToDefault.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Scroll;
            this.btnBackToDefault.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBackToDefault.Location = new System.Drawing.Point(229, 548);
            this.btnBackToDefault.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToDefault.Name = "btnBackToDefault";
            this.btnBackToDefault.Size = new System.Drawing.Size(119, 72);
            this.btnBackToDefault.TabIndex = 6;
            this.btnBackToDefault.Text = "Defult Color Mode";
            this.btnBackToDefault.UseVisualStyleBackColor = true;
            this.btnBackToDefault.Click += new System.EventHandler(this.btnBackToDefault_Click);
            // 
            // btnChangeColorMode
            // 
            this.btnChangeColorMode.Font = new System.Drawing.Font("Papyrus", 10.2F);
            this.btnChangeColorMode.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Briefcase;
            this.btnChangeColorMode.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnChangeColorMode.Location = new System.Drawing.Point(102, 548);
            this.btnChangeColorMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeColorMode.Name = "btnChangeColorMode";
            this.btnChangeColorMode.Size = new System.Drawing.Size(119, 72);
            this.btnChangeColorMode.TabIndex = 5;
            this.btnChangeColorMode.Text = "Change Color Mode";
            this.btnChangeColorMode.UseVisualStyleBackColor = true;
            this.btnChangeColorMode.Click += new System.EventHandler(this.btnChangeColorMode_Click);
            // 
            // btnRestartRound
            // 
            this.btnRestartRound.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold);
            this.btnRestartRound.Image = global::_3.Tic_Tac_Toe_Game.Properties.Resources.Restart;
            this.btnRestartRound.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestartRound.Location = new System.Drawing.Point(102, 421);
            this.btnRestartRound.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestartRound.Name = "btnRestartRound";
            this.btnRestartRound.Size = new System.Drawing.Size(246, 79);
            this.btnRestartRound.TabIndex = 3;
            this.btnRestartRound.Text = "Restart Round";
            this.btnRestartRound.UseVisualStyleBackColor = true;
            this.btnRestartRound.Click += new System.EventHandler(this.btnRestartRound_Click);
            // 
            // frmTicTacToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1000, 637);
            this.Controls.Add(this.chkAutoRestart);
            this.Controls.Add(this.btnUseNumpad);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbCards);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDrawTimes);
            this.Controls.Add(this.btnBackToDefault);
            this.Controls.Add(this.btnChangeColorMode);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRestartRound);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTurnPlayer);
            this.Controls.Add(this.lblFinalRound);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.lblRoundTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTicTacToeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.Load += new System.EventHandler(this.frmTicTacToeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTicTacToeGame_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCards.ResumeLayout(false);
            this.gbCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurnPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartRound;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackToDefault;
        private System.Windows.Forms.Button btnChangeColorMode;
        private System.Windows.Forms.Label lblGDplayer1;
        private System.Windows.Forms.Label lblP1Wins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGDplayer2;
        private System.Windows.Forms.Label lblP2Wins;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.GroupBox gbCards;
        private System.Windows.Forms.Label lblFinalRound;
        private System.Windows.Forms.Label lblDrawTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.CheckBox chkAutoRestart;
        private System.Windows.Forms.Label lblShadow;
        private System.Windows.Forms.Button btnUseNumpad;
        private System.Windows.Forms.Label lblRoundTitle;
    }
}

