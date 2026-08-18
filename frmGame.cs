using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
// جرب تخلي اللاعب يخار في الأول هل يلاعب حد معاه ولا الكومبيوتر 
// الكومبيوتر بيختار عشوائي من 1:9 والمستوى التاني عشوائي بررده بس من طرق الفوز ينقي ما بينهم
// ممكن أضيف هيستوري للجيم 
// ممكن كمان أحط حفظ لثيم محدد يمكن استعماله بعدين او اختياره من الثميات
// إعدادات اللعب باللوحة فقط (الأرقام) والحروف زي R --> Restart رسالة طبعاً قبلها عشان ميعدش الجيم فجأة

namespace _3.Tic_Tac_Toe_Game
{
    public partial class frmTicTacToeGame : Form
    {
        private frmMain _frmMain;

        private string _player1Name;
        private string _player2Name;
        private sbyte _howManyRounds;

        private byte _roundNumber = 1;
        private byte _player1WinTimes = 0;
        private byte _player2WinTimes = 0;
        private byte _drawTimes = 0;

        public frmTicTacToeGame()
        {
            InitializeComponent();
        }

        public frmTicTacToeGame(string player1 = "Player1",
            string player2 = "Player2", sbyte howManyRounds = -1, frmMain frmMain = null)
        {
            InitializeComponent();

            _player1Name = player1;
            _player2Name = player2;
            _howManyRounds = howManyRounds;
            _frmMain = frmMain;

            //     CenterObjOverObj(lblTurnPlayer, btnRestartRound);
        }

        public enum enPlayer
        {
            Player1, Player2
        }
        
        public enum enWinner
        {
            Player1, Player2, Draw, GameInProgress
        }

        public struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;

        }

        public stGameStatus GameStatus;

        private enPlayer CurrentPlayer = enPlayer.Player1;


        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" &&
                btn1.Tag.ToString() == btn2.Tag.ToString() &&
                btn2.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.ForeColor = Color.Orchid;
                btn2.ForeColor = Color.Orchid;
                btn3.ForeColor = Color.Orchid;

                GameStatus.GameOver = true;

                GameStatus.Winner = btn1.Tag.ToString() == "X" ? enWinner.Player1 : enWinner.Player2;

                lblWinner.Text = GameStatus.Winner.ToString().ToUpper();

                MessageBox.Show(lblWinner.Text + " Wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                UpdateWinnerScore();

                EndRound();

                return true;
            }

            return false;
        }


        public void CheckWinner()
        {
            if (CheckValues(btn1, btn2, btn3)) return;
            if (CheckValues(btn4, btn5, btn6)) return;
            if (CheckValues(btn7, btn8, btn9)) return;

            if (CheckValues(btn1, btn4, btn7)) return;
            if (CheckValues(btn2, btn5, btn8)) return;
            if (CheckValues(btn3, btn6, btn9)) return;

            if (CheckValues(btn1, btn5, btn9)) return;
            if (CheckValues(btn3, btn5, btn7)) return;


            // Draw
            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;

                //_drawTimes++;

                lblWinner.Text = "Draw";

                MessageBox.Show( "It's Draw!","Game Over",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                UpdateWinnerScore();
                EndRound();
            }
        }


        public void ChangeXorO(Button btn)
        {
            if (btn.Tag.ToString() != "?")
                return;

            if (GameStatus.GameOver)
            {
                MessageBox.Show("Wrong Choice", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (CurrentPlayer == enPlayer.Player1)
            {
                btn.Text = "X";
                btn.Tag = "X";
                btn.ForeColor = Color.DarkSalmon;

                lblTurnPlayer.Text = _player2Name;

                CurrentPlayer = enPlayer.Player2;
            }
            else
            {
                btn.Text = "O";
                btn.Tag = "O";
                btn.ForeColor = Color.White;

                lblTurnPlayer.Text = _player1Name;

                CurrentPlayer = enPlayer.Player1;
            }

            GameStatus.PlayCount++;

            CheckWinner();

        }


        private void UpdateWinnerScore()
        {
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    _player1WinTimes++;
                    lblP1Wins.Text = _player1WinTimes.ToString();
                    break;

                case enWinner.Player2:
                    _player2WinTimes++;
                    lblP2Wins.Text = _player2WinTimes.ToString();
                    break;

                case enWinner.Draw:
                    _drawTimes++;
                    lblDrawTimes.Text = _drawTimes.ToString();
                    break;
            }
            //  CenterLabelOverButton(lblWinner, btnRestartRound); 
            //   CenterObjOverObj(lblWinner, btnRestartRound);

        }


        private void EndRound()
        {
            _roundNumber++;
            if (chkAutoRestart.Checked) { RestartRound(); }

            if (_howManyRounds == -1) return;

            if (_roundNumber == _howManyRounds)
            {
                lblFinalRound.Visible = true;
                return;
            }
            if (_roundNumber > _howManyRounds)
            {
                frmGameResults frmGameResults = new frmGameResults(_player1Name, _player1WinTimes, _player2Name, _player2WinTimes, _drawTimes, _howManyRounds, this, _frmMain);
                _roundNumber--;
                frmGameResults.ShowDialog();
            }
            UpdateRoundNumber();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            ChangeXorO((Button)sender);
        }


        private void UpdateRoundNumber()
        {
            lblRoundNumber.Text = $"{_roundNumber}/{_howManyRounds}";

            if (_roundNumber == _howManyRounds)
                lblFinalRound.Visible = true;
        }

        public void DefaultValues()
        {
            RestartRound();
            _player1WinTimes = 0;
            _player2WinTimes = 0;
            _drawTimes = 0;
            lblDrawTimes.Text = "0";
            lblP1Wins.Text = "0";
            lblP2Wins.Text = "0";

            if (_howManyRounds == -1)
            {
                lblRoundNumber.Text = "Infinite Rounds";
                //   CenterLabelOverButton(lblRoundNumber, btnRestartRound);
                return;
            }

            _roundNumber = 1;
            UpdateRoundNumber();
            //frmTicTacToeGame_Load(null, null);
        }
        private void RestartRound()
        {
            if (lblWinner.Text == "IN PROGRESS")
            {
                if (MessageBox.Show("Are You Sure You Want To Restart The Round?", "Restart", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }

            GameStatus = new stGameStatus();

            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.GameOver = false;

            CurrentPlayer = enPlayer.Player1;

            lblTurnPlayer.Text = _player1Name.Trim();
            lblWinner.Text = "IN PROGRESS";
            // CenterObjOverObj(lblWinner, btnRestartRound);
            foreach (Button btn in gbCards.Controls.OfType<Button>().Where(B => B.Tag != null))
            {
                btn.Text = "?";
                btn.Tag = "?";
                btn.ForeColor = Color.Red;
            }


        }
        private void btnRestartRound_Click(object sender, EventArgs e)
        {
            RestartRound();
        }


        private void btnChangeColorMode_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);

            this.BackColor = Color.FromArgb(r, g, b);

            Color titleLabels = Color.FromArgb(255 - r, 255 - g, 255 - b);

            label1.ForeColor = titleLabels;
            label2.ForeColor = label1.ForeColor;


            Color currentPlayer = Color.FromArgb(255 - b, 255 - r, 255 - g);

            lblTurnPlayer.ForeColor = currentPlayer;
            lblWinner.ForeColor = currentPlayer;
        }


        private void btnBackToDefault_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(53, 27, 209);

            label1.ForeColor = Color.FromArgb(202, 228, 46);

            label2.ForeColor = label1.ForeColor;

            lblTurnPlayer.ForeColor = Color.FromArgb(46, 202, 228);

            lblWinner.ForeColor = lblTurnPlayer.ForeColor;
        }


        private void CenterObjOverObj(Control obj1, Control obj2)
        {
            obj1.AutoSize = true;

            obj1.Left = obj2.Left + (obj2.Width - obj1.Width) / 2;
        }
        private void frmTicTacToeGame_Load(object sender, EventArgs e)
        {

            GameStatus.Winner = enWinner.GameInProgress;

            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;

            lblTurnPlayer.Text = _player1Name.Trim();
            if (_howManyRounds == -1)
            {
                lblRoundNumber.Text = "Infinite Rounds";
                //CenterLabelOverButton(lblRoundNumber, btnRestartRound); 
            }
            else
                UpdateRoundNumber();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _frmMain.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want back to main screen?\nYou will lose your progress!", "Back to main screen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            else
            {
                _frmMain.Show();
                this.Close();
            }
        }

        private void lblTurnPlayer_Click(object sender, EventArgs e)
        {

        }

        private void chkAutoRestart_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void lblTurnPlayer_SizeChanged(object sender, EventArgs e)
        {
            CenterObjOverObj(lblTurnPlayer, btnRestartRound);
        }

        private void lblRoundNumber_SizeChanged(object sender, EventArgs e)
        {
            CenterObjOverObj(lblRoundNumber, btnRestartRound);
        }

        private void lblWinner_SizeChanged(object sender, EventArgs e)
        {
            CenterObjOverObj(lblWinner, btnRestartRound);

        }
        private void ComputerPlay()
        {
            List<Button> availableButtons = gbCards.Controls.OfType<Button>().Where(B => B.Tag?.ToString() == "?").ToList();
            if (availableButtons.Count == 0) { return; }
            Random random = new Random();

            int randomIndex = random.Next(0, availableButtons.Count);

            Button selectedButton = availableButtons[randomIndex];

            ChangeXorO(selectedButton);

        }
    }
}
