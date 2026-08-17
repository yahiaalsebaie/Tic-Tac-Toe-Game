using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Tic_Tac_Toe_Game
{
    public partial class frmGameResults : Form
    {
        private frmMain _frmMain;
        private frmTicTacToeGame _frmTicTacToeGame;
        public frmGameResults()
        {
            InitializeComponent();
        }
        public frmGameResults()
        {
            InitializeComponent();
        }

        private void lblRoundNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            _frmTicTacToeGame.RestartGame();
            this.Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            _frmMain.Show();
            this.Close();
        }
    }
}
