using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace _3.Tic_Tac_Toe_Game
{
    public partial class frmGameResults : Form
    {
        private frmMain _frmMain;
        private frmTicTacToeGame _frmTicTacToeGame;

        private string _player1Name;
        private string _player2Name;
        private sbyte _howManyRounds;
        private byte _player1WinTimes = 0;
        private byte _player2WinTimes = 0;
        private byte _drawTimes = 0;
        public frmGameResults()
        {
            InitializeComponent();
        }
        public frmGameResults(string player1Name, byte player1WinTimes, string player2Name, byte player2WinTimes, byte drawTimes, sbyte howManyRounds, frmTicTacToeGame frmGame, frmMain frmMain)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
            _howManyRounds = howManyRounds;
            _player1WinTimes = player1WinTimes;
            _player2WinTimes = player2WinTimes;
            _drawTimes = drawTimes;
            _frmMain = frmMain;
            _frmTicTacToeGame = frmGame;
            InitializeComponent();
        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            _frmTicTacToeGame.DefaultValues();
            this.Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            _frmTicTacToeGame.Close();
            _frmMain.Show();
            this.Close();
        }

        private string HowWonTheGame()
        {
            if (_player1WinTimes == _player2WinTimes) return " Draw";
            if (_player1WinTimes > _player2WinTimes) return _player1Name;
            else return _player2Name;
        }
        private void frmGameResults_Load(object sender, EventArgs e)
        {
            lblRoundNumber.Text = _howManyRounds.ToString();
            if (_howManyRounds == 1) label1.Text = "Round.";
            lblP1Wins.Text = _player1WinTimes.ToString();
            lblP2Wins.Text = _player2WinTimes.ToString();
            lblDrawTimes.Text = _drawTimes.ToString();
            lblWinnerPlayer.Text = HowWonTheGame();
            lblP1Name.Text = _player1Name;
            lblP2Name.Text = _player2Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CenterObjOverObj(Control obj1, Control obj2)
        {
            obj1.AutoSize = true;

            obj1.Left = obj2.Left + (obj2.Width - obj1.Width) / 2;
        }

        private void lblWinnerPlayer_TextChanged(object sender, EventArgs e)
        {
            CenterObjOverObj(lblWinnerPlayer, lblTitle);
        }
    }
}
