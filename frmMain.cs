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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = -1;
            }
            else numericUpDown1.Enabled = true;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            frmTicTacToeGame frmTicTacToeGame = new frmTicTacToeGame(txtPlayer1Name.Text.Trim(), txtPlayer2Name.Text.Trim(), (sbyte)numericUpDown1.Value);
            frmTicTacToeGame.ShowDialog();
        }

        private void rbComputer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComputer.Checked)
            {
                lblPlayer2Title.Visible = false;
                txtPlayer2Name.Visible = false;
                txtPlayer2Name.Text = "Computer";
            }
            else
            {
                lblPlayer2Title.Visible = true;
                txtPlayer2Name.Visible = true;
            }

        }
    }
}
